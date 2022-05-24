namespace _3P_PatyLopez
{
    public partial class Form1 : Form
    {
        private Subject subject = new Subject();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var observerTxtF = new ConcreteObserverA();
            subject.Attach(observerTxtF);

            var observerTxtB = new ConcreteObserverB();
            subject.Attach(observerTxtB);

            var observerGrid = new ConcreteObserverC();
            subject.Attach(observerGrid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBoxTxt_CheckedChanged(object sender, EventArgs e)
        {
            subject.SomeBusinessLogic("A", checkBoxTxt.Checked);
        }

        private void checkBoxTextbox_CheckedChanged(object sender, EventArgs e)
        {
            subject.SomeBusinessLogic("B", checkBoxTextbox.Checked);
        }

        private void checkBoxGrid_CheckedChanged(object sender, EventArgs e)
        {
            subject.SomeBusinessLogic("C", checkBoxGrid.Checked);
        }
    }
}