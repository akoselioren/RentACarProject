﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public interface IFileHelperService
    {
        public string Upload(List<IFormFile> file, string root);
        public void Delete(string filePath);
        public string Update(List<IFormFile> file, string filePath, string root);
    }
}
