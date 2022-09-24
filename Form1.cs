
using MaterialSkin.Controls;
namespace MATERIAL_CALCULATOR
{
    public partial class Form1 : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100,MaterialSkin.Accent.Pink200,MaterialSkin.TextShade.WHITE);


        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = int.Parse(num1.Text);
                int val2 = int.Parse(num2.Text);
                double suma = val1 + val2;

                result.Text  = suma.ToString(); 
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}