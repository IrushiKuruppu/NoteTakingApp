using System.Data;
using System.Linq.Expressions;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"].ToString();
            txtNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex]["Notes"].ToString();
            editing = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valied note!");
            }
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtNote.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Notes"] = txtNote.Text;
            }
            else
            {
                notes.Rows.Add(txtTitle.Text, txtNote.Text);
                txtTitle.Clear();
                txtNote.Clear();
                editing = false;

            }
        }
        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Notes");
            previousNotes.DataSource = notes;
        }

    }
}