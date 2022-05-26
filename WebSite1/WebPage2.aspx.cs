using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebPage2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            LoadRecord();
            TableDetails.Visible = false;
            HiddenID.Value = "0";
        }
        
    }

    SqlConnection con = new SqlConnection("Data Source=DESKTOP-DQJCTIH;Initial Catalog=Contacts;Integrated Security=True");
    protected void ButtonSave_Click(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand comm = new SqlCommand("insert into Contacts_tab values('"+TextBoxName.Text+ "','" +TextBoxPhoneNumber.Text+ "','" +TextBoxAddress.Text+ "')", con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully inserted')", true);
        LoadRecord();
    }

    void LoadRecord()
    {
        SqlCommand comm = new SqlCommand("select * from Contacts_tab",con);
        SqlDataAdapter d = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("update  Contacts_tab set Name = '"+TextBoxName.Text+ "',Phone =  '" + TextBoxPhoneNumber.Text + "',Address = '" + TextBoxAddress.Text + "' where ID = '"+int.Parse(HiddenID.Value)+"'",con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated')", true);
        LoadRecord();
    }

    protected void ButtonAddNew_Click(object sender, EventArgs e)
    {
        TableDetails.Visible = true;
        HiddenID.Value = "0";

        ButtonAddNew.Visible = false;

    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int val = Convert.ToInt16(e.Values[0]);
        if (val > 0)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("delete Contacts_tab where ID = '" + val + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted')", true);
            LoadRecord();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        


    }

    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand comm = new SqlCommand("delete Contacts_tab where Name = '"+TextBoxName.Text+"'",con);
        comm.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully deleted')", true);
        LoadRecord();

    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView gridView = sender as GridView;
        
        
        int id = Convert.ToInt16(gridView.Rows[e.NewEditIndex].Cells[1].Text);

        SqlCommand comm = new SqlCommand("select * from Contacts_tab where ID = "+id, con);
        SqlDataAdapter d = new SqlDataAdapter(comm);
        DataTable dt = new DataTable();
        d.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            DataRow di = dt.Rows[0];
            TextBoxName.Text = Convert.ToString(di[1]);
            TextBoxPhoneNumber.Text = Convert.ToString(di[2]);
            TextBoxAddress.Text = Convert.ToString(di[3]);
            TableDetails.Visible = true;
            HiddenID.Value = Convert.ToString(id);

            ButtonAddNew.Visible = false;
        }
        
    }
}