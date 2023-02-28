using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
           _colorDal.Add(color);
            return new SuccessResult(ColorMessages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(ColorMessages.ColorDeleted);
        }

        public IDataResult<List<Color>>GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), ColorMessages.ColorsListed);
        }

        public IDataResult<Color>GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(cl => cl.Id == id), ColorMessages.ColorByIdListed);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(ColorMessages.ColorUpdated);
        }
    }
}
