namespace QueueingApplication
{
    public class CashierClass{

        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;


        static int openFormsCount = 2;
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }

        public static void Main(string[] args)
        {
            QueuingForm form1 = new QueuingForm();
            CashierWindowQueue form2 = new CashierWindowQueue();

            form1.FormClosed += OnFormClosed;
            form2.FormClosed += OnFormClosed;

            form1.Show();
            form2.Show();

            Application.Run();


        }
        static void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            openFormsCount--;
            if (openFormsCount == 0)
            {
                Application.Exit();
            }
        }
    }
}