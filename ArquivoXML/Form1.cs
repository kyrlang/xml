using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArquivoXML
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
                      //define as propriedades do controle 
            //OpenFileDialog
            //this.ofd1.Multiselect = true;
            //this.ofd1.Title = "Selecionar Fotos";
            ////ofd1.InitialDirectory = @"C:\Users\macoratti\Pictures";
            ////filtra para exibir somente arquivos de imagens
            ////ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            //ofd1.CheckFileExists = true;
            //ofd1.CheckPathExists = true;
            //ofd1.FilterIndex = 2;
            //ofd1.RestoreDirectory = true;
            //ofd1.ReadOnlyChecked = true;
            //ofd1.ShowReadOnly = true;
            
            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                string arquivo;

                arquivo = ofd1.FileName;

                lblArquivo.Text = arquivo;
                lblArquivo.Visible = true;

                DataSet ds = new DataSet();
                DataTable retorno = new DataTable();
                ds.ReadXml(arquivo);

                grdXml.DataSource = ds.Tables[0];

                int cont = 0;

                while (cont < grdXml.Columns.Count)
                {
                    if (!(grdXml.Columns[cont].HeaderText == "nome"))
                        grdXml.Columns[cont].Visible = false;

                    cont++;
                }
                
                
                // Le os arquivos selecionados 
                //foreach (String arquivo in ofd1.FileNames)
                //{
                


                //XDocument xDoc = XDocument.Parse(arquivo);

                //var resultado = (from x in xDoc.Descendants()
                //                 select new
                //                 {
                //                     Nome = x.Element("nome").Value,
                //                     Idade = x.Element("telefone").Value
                //                 }
                //                ).ToList();



                     

                //    // cria um PictureBox
                //    try
                //    {
                //        PictureBox pb = new PictureBox();
                //        Image Imagem = Image.FromFile(arquivo);
                //        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                //        //para exibir as imagens em tamanho natural 
                //        //descomente as linhas abaixo e comente as duas seguintes
                //        //pb.Height = loadedImage.Height;
                //        //pb.Width = loadedImage.Width;
                //        pb.Height = 100;
                //        pb.Width = 100;
                //        //atribui a imagem ao PictureBox - pb
                //        pb.Image = Imagem;
                //        //inclui a imagem no containter flowLayoutPanel
                //        flowLayoutPanel1.Controls.Add(pb);
                //    }
                //    catch (SecurityException ex)
                //    {
                //        // O usuário  não possui permissão para ler arquivos
                //        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                //                                    "Mensagem : " + ex.Message + "\n\n" +
                //                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                //    }
                //    catch (Exception ex)
                //    {
                //        // Não pode carregar a imagem (problemas de permissão)
                //        MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(file.LastIndexOf('\\'))
                //                                   + ". Você pode não ter permissão para ler o arquivo , ou " +
                //                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                //    }
                //}
            //}
        }//fim e evento botão
        }

        private void btnXml_Click_1(object sender, EventArgs e)
        {

        }
    }
}
