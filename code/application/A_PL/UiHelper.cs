namespace application.A_PL
{
    public static class UiHelper
    {
        public static bool ProgramaticallyClosing = false;
        public static void ProxyClose(Form form)
        {
            ProgramaticallyClosing = true;
            form.Close();
            // ProgramaticallyClosing will be reset in the FormClosing handler
        }
        public static void ProxyExit()
        {
            Application.Exit();
            ProgramaticallyClosing = false;
        }
    }
}
