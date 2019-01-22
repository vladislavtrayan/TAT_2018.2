namespace SeleniumTestFramework.Pages
{
    /// <summary>
    /// Operates with page objects
    /// </summary>
    public static class Pages
    {
        /// <summary>
        /// return Login page
        /// </summary>
        public static LoginPage LoginPage
        {
            get 
            {
                var loginPage = new LoginPage();
                return loginPage; 
            }
        }
        /// <summary>
        /// return Route page
        /// </summary>
        public static RoutePage RoutePage
        {
            get
            {
                var routePage = new RoutePage();
                return routePage;
            }
        }
        /// <summary>
        /// return wait box page
        /// </summary>
        public static WaitBox WaitBox
        {
            get
            {
                var waitBox = new WaitBox();
                return waitBox;
            }
        }
        /// <summary>
        /// return check box page
        /// </summary>
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
