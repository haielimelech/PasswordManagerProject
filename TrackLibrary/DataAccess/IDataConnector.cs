using System;
using System.Collections.Generic;
using System.Text;
using TrackLibrary.Models;

namespace TrackLibrary.DataAccess
{
    public interface IDataConnector
    {
        PasswordModel CreatePassword(PasswordModel model);
        List<PasswordModel> GetPassword_All();
        void DeletePassword(PasswordModel model);
    }
}
