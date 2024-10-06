namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        private IShapeFactory shapeFactory;
        private List<IShape> shapes;
        public Form1()
        {
            InitializeComponent();

            factoryComboBox.Items.AddRange(new string[] { "Красная фабрика", "Синяя фабрика", "Зеленая фабрика" });
            factoryComboBox.SelectedIndex = 0;
            factoryComboBox.SelectedIndexChanged += OnFactoryChanged;

            shapeFactory = new RedFactory();
            shapes = new List<IShape>();

            drawingPanel.Paint += OnPanelPaint;
        }

        private void OnFactoryChanged(object sender, EventArgs e)
        {
            switch (factoryComboBox.SelectedIndex)
            {
                case 0:
                    shapeFactory = new RedFactory();
                    break;
                case 1:
                    shapeFactory = new BlueFactory();
                    break;
                case 2:
                    shapeFactory = new GreenFactory();
                    break;
            }

            shapes.Clear();
            drawingPanel.Invalidate();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            shapes.Clear();

            shapes.Add(shapeFactory.CreateCircle());
            shapes.Add(shapeFactory.CreateSquare());
            shapes.Add(shapeFactory.CreateTriangle());

            drawingPanel.Invalidate();
        }

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }
        }
    }
}
