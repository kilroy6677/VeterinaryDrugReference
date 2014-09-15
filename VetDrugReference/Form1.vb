'This is a program I wrote for veterinarians.  It allows vets to choose a drug, species,
'and use, then enter a weight in pounds.  The program converts the weight from pounds
'to kilograms and figure the dosages based on database values.  There are only a few drugs
'in the database at present.

Public Class frmVetDrugs
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DrugsTableAdapter.Fill(Me.VeterinaryDrugsDataSet.Drugs)

    End Sub

    Private Sub cboDrugName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDrugName.SelectionChangeCommitted

        Try
            Me.SpeciesTableAdapter.FillByDrugID(Me.VeterinaryDrugsDataSet.Species, cboDrugName.SelectedValue)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cboSpeciesName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSpeciesName.SelectionChangeCommitted
        Try
            Me.UsesTableAdapter.FillByDrugIDSpeciesID(Me.VeterinaryDrugsDataSet.Uses, cboDrugName.SelectedValue, cboSpeciesName.SelectedValue)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cboUseName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUseName.SelectionChangeCommitted

        Try
            Me.DosagesTableAdapter.FillByUseID(Me.VeterinaryDrugsDataSet.Dosages, cboUseName.SelectedValue)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim minDosageStart As Decimal
        Dim maxDosageStart As Decimal
        Dim weightPounds As Decimal
        Dim weightKilo As Decimal
        Dim minDosageCalc As Decimal
        Dim maxDosageCalc As Decimal

        minDosageStart = lblMinDosageValue.Text
        maxDosageStart = lblMaxDosageValue.Text
        weightPounds = txtWeight.Text
        weightKilo = (weightPounds / 2.2)
        minDosageCalc = minDosageStart * weightKilo
        maxDosageCalc = maxDosageStart * weightKilo

        lblMinDosageCalculate.Text = FormatNumber(minDosageCalc, 3)
        lblMaxDosageCalculate.Text = FormatNumber(maxDosageCalc, 3)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub EditDrugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDrugToolStripMenuItem.Click
        lblEditMode.Visible = True
        btnCalculate.Visible = False
        btnAccept.Visible = True
        btnCancel.Visible = True
        lblWeight.Visible = False
        txtWeight.Visible = False
        lblCalculateInfo.Visible = False
        lblMinDosageCalculate.Visible = False
        lblMinDosageCalculateName.Visible = False
        lblMaxDosageCalculate.Visible = False
        lblMaxDosageCalculateName.Visible = False
        lblMinDosageValue.Visible = False
        lblMaxDosageValue.Visible = False
        txtMinDosage.Visible = True
        txtMaxDosage.Visible = True
        lblCommentsValue.Visible = False
        txtComments.Visible = True

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        lblEditMode.Visible = False
        btnCalculate.Visible = True
        btnAccept.Visible = False
        btnCancel.Visible = False
        lblWeight.Visible = True
        txtWeight.Visible = True
        lblCalculateInfo.Visible = True
        lblMinDosageCalculate.Visible = True
        lblMinDosageCalculateName.Visible = True
        lblMaxDosageCalculate.Visible = True
        lblMaxDosageCalculateName.Visible = True
        lblMinDosageValue.Visible = True
        lblMaxDosageValue.Visible = True
        lblCommentsValue.Visible = True
        txtComments.Visible = False
        txtMinDosage.Visible = False
        txtMaxDosage.Visible = False


    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        lblEditMode.Visible = False
        btnCalculate.Visible = True
        btnAccept.Visible = False
        btnCancel.Visible = False
        lblWeight.Visible = True
        txtWeight.Visible = True
        lblCalculateInfo.Visible = True
        lblMinDosageCalculate.Visible = True
        lblMinDosageCalculateName.Visible = True
        lblMaxDosageCalculate.Visible = True
        lblMaxDosageCalculateName.Visible = True
        lblMinDosageValue.Visible = True
        lblMaxDosageValue.Visible = True
        lblCommentsValue.Visible = True
        txtComments.Visible = False
        txtMinDosage.Visible = False
        txtMaxDosage.Visible = False

    End Sub
End Class
