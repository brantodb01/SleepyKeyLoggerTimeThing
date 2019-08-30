using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace goodjobmrmouse
{
    class MrDirector
    {
        string pathFounder;
        bool ancientRuin;
        string homeSweetHome = new string (string.Format(@"{0}\mrmouse", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

        public MrDirector()
        {
            pathFounder = pathFinder();
            areYouStillThere();

        }

        public string pathFinder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public void areYouStillThere()
        {
            if(File.Exists (homeSweetHome.ToString()))
            {
                ///leave this place
            }
            else
            {
                mesopotamian();
            }
        }

        public void mesopotamian()
        {
            Directory.CreateDirectory(homeSweetHome);
        }


    }
}
