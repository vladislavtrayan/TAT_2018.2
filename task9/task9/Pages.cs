using System;
namespace task9
{
    public static class Pages
    {
        public static LoginPage LoginPage
        {
            get 
            {
                var loginPage = new LoginPage();
                return loginPage; 
            }
        }
        public static RoutePage RoutePage
        {
            get
            {
                var routePage = new RoutePage();
                return routePage;
            }
        }
        public static WaitBox WaitBox
        {
            get
            {
                var waitBox = new WaitBox();
                return waitBox;
            }
        }
        public static CheckBox CheckBox
        {
            get
            {
                var checkBox = new CheckBox();
                return checkBox;
            }
        }
    }
}
