

#include <draw3d/pointcloud.h>
#include <draw3d/convert.h>
#include <osg/Geometry>
#include <osg/Geode>

namespace Parsley {
  namespace Draw3D {

    PointCloud::PointCloud() {
      auto_ptr_osg<osg::Geode> geode = this->osg();
      _geometry = new osg::Geometry();
      _vertices = new osg::Vec3Array();
      _primitives = new osg::DrawElementsUInt(osg::PrimitiveSet::POINTS, 0);

      _geometry->setVertexArray(_vertices.get());
      _geometry->addPrimitiveSet(_primitives.get());

      _colors = new osg::Vec4Array();
      _geometry->setColorArray(_colors.get());
      _geometry->setColorBinding(osg::Geometry::BIND_PER_VERTEX);

      // Note: using _geometry->dirtyDisplayList on vertex modifications leads
      // to flickering. In the future we should switch to display lists when scanning
      // is complete, or no points have been added for a while.
      _geometry->setUseDisplayList(false);

      
      geode->getOrCreateStateSet()->setMode(GL_LIGHTING, osg::StateAttribute::OFF);
      geode->addDrawable(_geometry.get());
      
    }

    unsigned  
      PointCloud::AddPoint(cli::array<double,1> ^x, cli::array<double,1> ^color) 
    {
      unsigned id = _vertices->size();
      _colors->push_back(convert4(color));
      _vertices->push_back(convert3(x));
      _primitives->push_back(_primitives->size());
      return id;
    }

    void
      PointCloud::UpdatePoint(unsigned id, array<double>^ x, array<double>^ color)
    {
      _colors->at(id) = convert4(color);
      _vertices->at(id) = convert3(x);
    }

    void
      PointCloud::ClearPoints() 
    {
      _vertices->clear();
      _colors->clear();
      _primitives->clear();
    }
  }
}