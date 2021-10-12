using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfProtWpfApp1.MVVM.Model
{

    [Serializable]
    public class UserModel : UserCardModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsConfined { get; set; }

        public UserModel()
        { }
    }
}
