using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MP3TagRenamer
{
    public partial class FormDeleteFileList : Form
    {
        private DataTable my_delete_table ;
        private DataColumn my_path_datacolumn;
        private DataColumn my_delete_datacolumn;

        public FormDeleteFileList()
        {
            InitializeComponent();
        }

        public void FillList( DataTable delete_table, DataColumn path_datacolumn, DataColumn delete_datacolumn )
        {
            this.my_delete_table = delete_table;
            this.my_delete_datacolumn = delete_datacolumn;
            this.my_path_datacolumn = path_datacolumn;

            foreach( DataRow _dr in my_delete_table.Rows ) {
                if( (bool)_dr[my_delete_datacolumn] ) { 
                    my_checkedListBox_FilesPaths.Items.Add( _dr[my_path_datacolumn] , true);
                }
            }
        }


        private void Button_OK_Click( object sender, EventArgs e )
        {
            foreach( string _path in my_checkedListBox_FilesPaths.CheckedItems ) {

                try
                {
                    new System.IO.FileInfo( _path ).Delete();
                }catch (Exception ex){
                    MessageBox.Show( "Kunde inte radera filen " + Environment.NewLine +
                        _path+ Environment.NewLine +
                        ex.Message
                        );
                }
            }
        }
    }
}