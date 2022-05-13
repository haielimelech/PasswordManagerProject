using System;
using System.Collections.Generic;
using System.Text;
using TrackLibrary.Models;
using TrackLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackLibrary.DataAccess
{
    public class TextConnector : IDataConnector
    {
        private const string PasswordsFile = "PasswordsFile.txt";
        public PasswordModel CreatePassword(PasswordModel model)
        {
            List<PasswordModel> password = PasswordsFile.FullFillPath().LoadFile().ConvertToPasswordModels();
            int currentId = 1;

            if (password.Count >0)
            {
                currentId = password.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            password.Add(model);

            password.SaveToPasswordFile(PasswordsFile);

            return model;
        }

        public void DeletePassword(PasswordModel model)
        {
            int uniq = model.Id;
         List<PasswordModel> password = PasswordsFile.FullFillPath().LoadFile().ConvertToPasswordModels();
            foreach (PasswordModel item in password)
            {
                if (item.Id == uniq)
                {
                    password.Remove(item);
                    password.SaveToPasswordFile(PasswordsFile);
                    break;
                }
            }
        }

        public List<PasswordModel> GetPassword_All()
        {
            return PasswordsFile.FullFillPath().LoadFile().ConvertToPasswordModels();
        }
    }
}
