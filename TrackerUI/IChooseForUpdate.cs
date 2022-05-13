using System;
using System.Collections.Generic;
using System.Text;
using TrackLibrary.Models;
using TrackLibrary.DataAccess.TextHelpers;
using TrackLibrary.DataAccess;

namespace TrackerUI
{
    public interface IChooseForUpdate
    {
        void ChooseComplete(PasswordModel model);
    }
}
