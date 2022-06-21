namespace _3P_PatyLopez
{
    public partial class Form1 : Form
    {
        private Subject singletonSubject;
        private FacadeActionsClass facadeActionsClass;
        public Form1()
        {
            InitializeComponent();
            singletonSubject = Subject.GetInstance();
            facadeActionsClass = new FacadeActionsClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var observerTxtF = new ConcreteObserverA();
            singletonSubject.Attach(observerTxtF);

            var observerTxtB = new ConcreteObserverB();
            singletonSubject.Attach(observerTxtB);

            var observerGrid = new ConcreteObserverC();
            singletonSubject.Attach(observerGrid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxTxt_CheckedChanged(object sender, EventArgs e)
        {
            // singletonSubject.SomeBusinessLogic("A", checkBoxTxt.Checked);
        }

        private void checkBoxTextbox_CheckedChanged(object sender, EventArgs e)
        {
            // singletonSubject.SomeBusinessLogic("B", checkBoxTextbox.Checked);
        }

        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            // singletonSubject.SomeBusinessLogic("C", checkBoxGrid.Checked);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO add event
            singletonSubject.NotifyToAll(checkBoxTxt.Checked, checkBoxTextbox.Checked, checkBoxGrid.Checked);
            facadeActionsClass.ShowTakeOrderDialog();
        }

        private void gridLogs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            facadeActionsClass.ShowGenerateRouteDialog();
        }
    }
}