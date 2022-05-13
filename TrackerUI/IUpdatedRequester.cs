using System;
using System.Collections.Generic;
using System.Text;
using TrackLibrary.Models;

namespace TrackerUI
{
    public interface IUpdatedRequester
    {
        void UpdatedComplete(PasswordModel model);
    }
}
