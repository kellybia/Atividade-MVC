using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvc.DAL;
using mvc.DTO;

namespace mvc.BLL
{
    internal class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            LoginDAL loginDAL = new LoginDAL();

            return loginDAL.GetLoginDAL(loginDTO);
        }
    }
}