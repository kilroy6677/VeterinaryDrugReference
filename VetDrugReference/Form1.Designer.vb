<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVetDrugs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMaxDosageCalculate = New System.Windows.Forms.Label
        Me.lblMinDosageCalculate = New System.Windows.Forms.Label
        Me.lblMaxDosageCalculateName = New System.Windows.Forms.Label
        Me.lblMinDosageCalculateName = New System.Windows.Forms.Label
        Me.lblCalculateInfo = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.lblWeight = New System.Windows.Forms.Label
        Me.lblMaxDosageValue = New System.Windows.Forms.Label
        Me.VeterinaryDrugsDataSet = New VetDrugReference.VeterinaryDrugsDataSet
        Me.lblMaxDosage = New System.Windows.Forms.Label
        Me.lblMinDosage = New System.Windows.Forms.Label
        Me.cboUseName = New System.Windows.Forms.ComboBox
        Me.lblUseName = New System.Windows.Forms.Label
        Me.EditDrugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewDrugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cboSpeciesName = New System.Windows.Forms.ComboBox
        Me.lblSpeciesName = New System.Windows.Forms.Label
        Me.lblDrugName = New System.Windows.Forms.Label
        Me.cboDrugName = New System.Windows.Forms.ComboBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DrugsTableAdapter = New VetDrugReference.VeterinaryDrugsDataSetTableAdapters.DrugsTableAdapter
        Me.TableAdapterManager = New VetDrugReference.VeterinaryDrugsDataSetTableAdapters.TableAdapterManager
        Me.DosagesTableAdapter = New VetDrugReference.VeterinaryDrugsDataSetTableAdapters.DosagesTableAdapter
        Me.SpeciesTableAdapter = New VetDrugReference.VeterinaryDrugsDataSetTableAdapters.SpeciesTableAdapter
        Me.UsesTableAdapter = New VetDrugReference.VeterinaryDrugsDataSetTableAdapters.UsesTableAdapter
        Me.lblComments = New System.Windows.Forms.Label
        Me.lblCommentsValue = New System.Windows.Forms.Label
        Me.lblMinDosageValue = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblEditMode = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAccept = New System.Windows.Forms.Button
        Me.txtMinDosage = New System.Windows.Forms.TextBox
        Me.txtMaxDosage = New System.Windows.Forms.TextBox
        Me.txtComments = New System.Windows.Forms.TextBox
        CType(Me.VeterinaryDrugsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMaxDosageCalculate
        '
        Me.lblMaxDosageCalculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxDosageCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDosageCalculate.Location = New System.Drawing.Point(326, 575)
        Me.lblMaxDosageCalculate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxDosageCalculate.Name = "lblMaxDosageCalculate"
        Me.lblMaxDosageCalculate.Size = New System.Drawing.Size(136, 35)
        Me.lblMaxDosageCalculate.TabIndex = 37
        '
        'lblMinDosageCalculate
        '
        Me.lblMinDosageCalculate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinDosageCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinDosageCalculate.Location = New System.Drawing.Point(75, 575)
        Me.lblMinDosageCalculate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinDosageCalculate.Name = "lblMinDosageCalculate"
        Me.lblMinDosageCalculate.Size = New System.Drawing.Size(136, 35)
        Me.lblMinDosageCalculate.TabIndex = 36
        '
        'lblMaxDosageCalculateName
        '
        Me.lblMaxDosageCalculateName.AutoSize = True
        Me.lblMaxDosageCalculateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDosageCalculateName.Location = New System.Drawing.Point(321, 555)
        Me.lblMaxDosageCalculateName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxDosageCalculateName.Name = "lblMaxDosageCalculateName"
        Me.lblMaxDosageCalculateName.Size = New System.Drawing.Size(140, 20)
        Me.lblMaxDosageCalculateName.TabIndex = 35
        Me.lblMaxDosageCalculateName.Text = "Maximum Dosage:"
        '
        'lblMinDosageCalculateName
        '
        Me.lblMinDosageCalculateName.AutoSize = True
        Me.lblMinDosageCalculateName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinDosageCalculateName.Location = New System.Drawing.Point(75, 555)
        Me.lblMinDosageCalculateName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinDosageCalculateName.Name = "lblMinDosageCalculateName"
        Me.lblMinDosageCalculateName.Size = New System.Drawing.Size(136, 20)
        Me.lblMinDosageCalculateName.TabIndex = 34
        Me.lblMinDosageCalculateName.Text = "Minimum Dosage:"
        '
        'lblCalculateInfo
        '
        Me.lblCalculateInfo.AutoSize = True
        Me.lblCalculateInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculateInfo.Location = New System.Drawing.Point(154, 509)
        Me.lblCalculateInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCalculateInfo.Name = "lblCalculateInfo"
        Me.lblCalculateInfo.Size = New System.Drawing.Size(233, 20)
        Me.lblCalculateInfo.TabIndex = 33
        Me.lblCalculateInfo.Text = "Calculated Dosages for Weight:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(204, 631)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 35)
        Me.btnCalculate.TabIndex = 32
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(328, 454)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(181, 26)
        Me.txtWeight.TabIndex = 31
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(18, 458)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(298, 20)
        Me.lblWeight.TabIndex = 30
        Me.lblWeight.Text = "Please enter the weight in pounds (lbs.)..."
        '
        'lblMaxDosageValue
        '
        Me.lblMaxDosageValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxDosageValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VeterinaryDrugsDataSet, "Dosages.MaxDosage", True))
        Me.lblMaxDosageValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDosageValue.Location = New System.Drawing.Point(327, 323)
        Me.lblMaxDosageValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxDosageValue.Name = "lblMaxDosageValue"
        Me.lblMaxDosageValue.Size = New System.Drawing.Size(136, 35)
        Me.lblMaxDosageValue.TabIndex = 29
        '
        'VeterinaryDrugsDataSet
        '
        Me.VeterinaryDrugsDataSet.DataSetName = "VeterinaryDrugsDataSet"
        Me.VeterinaryDrugsDataSet.EnforceConstraints = False
        Me.VeterinaryDrugsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblMaxDosage
        '
        Me.lblMaxDosage.AutoSize = True
        Me.lblMaxDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDosage.Location = New System.Drawing.Point(323, 303)
        Me.lblMaxDosage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxDosage.Name = "lblMaxDosage"
        Me.lblMaxDosage.Size = New System.Drawing.Size(140, 20)
        Me.lblMaxDosage.TabIndex = 27
        Me.lblMaxDosage.Text = "Maximum Dosage:"
        '
        'lblMinDosage
        '
        Me.lblMinDosage.AutoSize = True
        Me.lblMinDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinDosage.Location = New System.Drawing.Point(77, 303)
        Me.lblMinDosage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinDosage.Name = "lblMinDosage"
        Me.lblMinDosage.Size = New System.Drawing.Size(136, 20)
        Me.lblMinDosage.TabIndex = 26
        Me.lblMinDosage.Text = "Minimum Dosage:"
        '
        'cboUseName
        '
        Me.cboUseName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VeterinaryDrugsDataSet, "Uses.UseID", True))
        Me.cboUseName.DataSource = Me.VeterinaryDrugsDataSet
        Me.cboUseName.DisplayMember = "Uses.Uses"
        Me.cboUseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUseName.FormattingEnabled = True
        Me.cboUseName.Location = New System.Drawing.Point(145, 237)
        Me.cboUseName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboUseName.Name = "cboUseName"
        Me.cboUseName.Size = New System.Drawing.Size(364, 28)
        Me.cboUseName.TabIndex = 25
        Me.cboUseName.ValueMember = "Uses.UseID"
        '
        'lblUseName
        '
        Me.lblUseName.AutoSize = True
        Me.lblUseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUseName.Location = New System.Drawing.Point(17, 241)
        Me.lblUseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUseName.Name = "lblUseName"
        Me.lblUseName.Size = New System.Drawing.Size(50, 20)
        Me.lblUseName.TabIndex = 24
        Me.lblUseName.Text = "Uses:"
        '
        'EditDrugToolStripMenuItem
        '
        Me.EditDrugToolStripMenuItem.Name = "EditDrugToolStripMenuItem"
        Me.EditDrugToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.EditDrugToolStripMenuItem.Text = "&Edit Drug"
        '
        'AddNewDrugToolStripMenuItem
        '
        Me.AddNewDrugToolStripMenuItem.Name = "AddNewDrugToolStripMenuItem"
        Me.AddNewDrugToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.AddNewDrugToolStripMenuItem.Text = "&Add New Drug"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewDrugToolStripMenuItem, Me.EditDrugToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'cboSpeciesName
        '
        Me.cboSpeciesName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VeterinaryDrugsDataSet, "Uses.SpeciesID", True))
        Me.cboSpeciesName.DataSource = Me.VeterinaryDrugsDataSet
        Me.cboSpeciesName.DisplayMember = "Species.SpeciesName"
        Me.cboSpeciesName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSpeciesName.FormattingEnabled = True
        Me.cboSpeciesName.Location = New System.Drawing.Point(145, 178)
        Me.cboSpeciesName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSpeciesName.Name = "cboSpeciesName"
        Me.cboSpeciesName.Size = New System.Drawing.Size(364, 28)
        Me.cboSpeciesName.TabIndex = 23
        Me.cboSpeciesName.ValueMember = "Species.FK_Dosages_Species.SpeciesID"
        '
        'lblSpeciesName
        '
        Me.lblSpeciesName.AutoSize = True
        Me.lblSpeciesName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeciesName.Location = New System.Drawing.Point(17, 183)
        Me.lblSpeciesName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSpeciesName.Name = "lblSpeciesName"
        Me.lblSpeciesName.Size = New System.Drawing.Size(116, 20)
        Me.lblSpeciesName.TabIndex = 22
        Me.lblSpeciesName.Text = "Species Name:"
        '
        'lblDrugName
        '
        Me.lblDrugName.AutoSize = True
        Me.lblDrugName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrugName.Location = New System.Drawing.Point(17, 123)
        Me.lblDrugName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDrugName.Name = "lblDrugName"
        Me.lblDrugName.Size = New System.Drawing.Size(94, 20)
        Me.lblDrugName.TabIndex = 20
        Me.lblDrugName.Text = "Drug Name:"
        '
        'cboDrugName
        '
        Me.cboDrugName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDrugName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDrugName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VeterinaryDrugsDataSet, "Drugs.FK_Dosages_Drugs.DrugID", True))
        Me.cboDrugName.DataSource = Me.VeterinaryDrugsDataSet
        Me.cboDrugName.DisplayMember = "Drugs.DrugName"
        Me.cboDrugName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDrugName.FormattingEnabled = True
        Me.cboDrugName.Location = New System.Drawing.Point(145, 119)
        Me.cboDrugName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboDrugName.Name = "cboDrugName"
        Me.cboDrugName.Size = New System.Drawing.Size(364, 28)
        Me.cboDrugName.TabIndex = 21
        Me.cboDrugName.ValueMember = "Drugs.DrugID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 30)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelToolStripMenuItem
        '
        Me.HelToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HelToolStripMenuItem.Name = "HelToolStripMenuItem"
        Me.HelToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.HelToolStripMenuItem.Text = "&Help"
        '
        'DrugsTableAdapter
        '
        Me.DrugsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DosagesTableAdapter = Me.DosagesTableAdapter
        Me.TableAdapterManager.DrugsTableAdapter = Me.DrugsTableAdapter
        Me.TableAdapterManager.SpeciesTableAdapter = Me.SpeciesTableAdapter
        Me.TableAdapterManager.UpdateOrder = VetDrugReference.VeterinaryDrugsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsesTableAdapter = Me.UsesTableAdapter
        '
        'DosagesTableAdapter
        '
        Me.DosagesTableAdapter.ClearBeforeFill = True
        '
        'SpeciesTableAdapter
        '
        Me.SpeciesTableAdapter.ClearBeforeFill = True
        '
        'UsesTableAdapter
        '
        Me.UsesTableAdapter.ClearBeforeFill = True
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComments.Location = New System.Drawing.Point(17, 383)
        Me.lblComments.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(90, 20)
        Me.lblComments.TabIndex = 38
        Me.lblComments.Text = "Comments:"
        '
        'lblCommentsValue
        '
        Me.lblCommentsValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommentsValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VeterinaryDrugsDataSet, "Dosages.Comments", True))
        Me.lblCommentsValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommentsValue.Location = New System.Drawing.Point(104, 383)
        Me.lblCommentsValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCommentsValue.Name = "lblCommentsValue"
        Me.lblCommentsValue.Size = New System.Drawing.Size(406, 52)
        Me.lblCommentsValue.TabIndex = 39
        '
        'lblMinDosageValue
        '
        Me.lblMinDosageValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinDosageValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VeterinaryDrugsDataSet, "Dosages.MinDosage", True))
        Me.lblMinDosageValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinDosageValue.Location = New System.Drawing.Point(81, 323)
        Me.lblMinDosageValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinDosageValue.Name = "lblMinDosageValue"
        Me.lblMinDosageValue.Size = New System.Drawing.Size(136, 35)
        Me.lblMinDosageValue.TabIndex = 40
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(140, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 26)
        Me.lblTitle.TabIndex = 41
        Me.lblTitle.Text = "Veterinary Drug Reference"
        '
        'lblEditMode
        '
        Me.lblEditMode.AutoSize = True
        Me.lblEditMode.Location = New System.Drawing.Point(210, 83)
        Me.lblEditMode.Name = "lblEditMode"
        Me.lblEditMode.Size = New System.Drawing.Size(106, 20)
        Me.lblEditMode.TabIndex = 42
        Me.lblEditMode.Text = "Edit Mode On"
        Me.lblEditMode.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(335, 631)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(135, 35)
        Me.btnCancel.TabIndex = 43
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(44, 631)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(135, 35)
        Me.btnAccept.TabIndex = 44
        Me.btnAccept.Text = "Accept Changes"
        Me.btnAccept.UseVisualStyleBackColor = True
        Me.btnAccept.Visible = False
        '
        'txtMinDosage
        '
        Me.txtMinDosage.Location = New System.Drawing.Point(81, 326)
        Me.txtMinDosage.Name = "txtMinDosage"
        Me.txtMinDosage.Size = New System.Drawing.Size(136, 26)
        Me.txtMinDosage.TabIndex = 45
        Me.txtMinDosage.Visible = False
        '
        'txtMaxDosage
        '
        Me.txtMaxDosage.Location = New System.Drawing.Point(325, 326)
        Me.txtMaxDosage.Name = "txtMaxDosage"
        Me.txtMaxDosage.Size = New System.Drawing.Size(136, 26)
        Me.txtMaxDosage.TabIndex = 46
        Me.txtMaxDosage.Visible = False
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(104, 383)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(406, 52)
        Me.txtComments.TabIndex = 47
        Me.txtComments.Visible = False
        '
        'frmVetDrugs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(549, 713)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtMaxDosage)
        Me.Controls.Add(Me.txtMinDosage)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblEditMode)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblMinDosageValue)
        Me.Controls.Add(Me.lblCommentsValue)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.lblMaxDosageCalculate)
        Me.Controls.Add(Me.lblMinDosageCalculate)
        Me.Controls.Add(Me.lblMaxDosageCalculateName)
        Me.Controls.Add(Me.lblMinDosageCalculateName)
        Me.Controls.Add(Me.lblCalculateInfo)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblMaxDosageValue)
        Me.Controls.Add(Me.lblMaxDosage)
        Me.Controls.Add(Me.lblMinDosage)
        Me.Controls.Add(Me.cboUseName)
        Me.Controls.Add(Me.lblUseName)
        Me.Controls.Add(Me.cboSpeciesName)
        Me.Controls.Add(Me.lblSpeciesName)
        Me.Controls.Add(Me.lblDrugName)
        Me.Controls.Add(Me.cboDrugName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VeterinaryDrugsDataSet, "Uses.Uses", True))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.VeterinaryDrugsDataSet, "Uses.UseID", True))
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmVetDrugs"
        Me.ShowIcon = False
        Me.Text = "Veterinary Drug Reference"
        CType(Me.VeterinaryDrugsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMaxDosageCalculate As System.Windows.Forms.Label
    Friend WithEvents lblMinDosageCalculate As System.Windows.Forms.Label
    Friend WithEvents lblMaxDosageCalculateName As System.Windows.Forms.Label
    Friend WithEvents lblMinDosageCalculateName As System.Windows.Forms.Label
    Friend WithEvents lblCalculateInfo As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblMaxDosageValue As System.Windows.Forms.Label
    Friend WithEvents lblMaxDosage As System.Windows.Forms.Label
    Friend WithEvents lblMinDosage As System.Windows.Forms.Label
    Friend WithEvents cboUseName As System.Windows.Forms.ComboBox
    Friend WithEvents lblUseName As System.Windows.Forms.Label
    Friend WithEvents EditDrugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewDrugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboSpeciesName As System.Windows.Forms.ComboBox
    Friend WithEvents lblSpeciesName As System.Windows.Forms.Label
    Friend WithEvents lblDrugName As System.Windows.Forms.Label
    Friend WithEvents cboDrugName As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VeterinaryDrugsDataSet As VetDrugReference.VeterinaryDrugsDataSet
    Friend WithEvents DrugsTableAdapter As VetDrugReference.VeterinaryDrugsDataSetTableAdapters.DrugsTableAdapter
    Friend WithEvents TableAdapterManager As VetDrugReference.VeterinaryDrugsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SpeciesTableAdapter As VetDrugReference.VeterinaryDrugsDataSetTableAdapters.SpeciesTableAdapter
    Friend WithEvents UsesTableAdapter As VetDrugReference.VeterinaryDrugsDataSetTableAdapters.UsesTableAdapter
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents lblCommentsValue As System.Windows.Forms.Label
    Friend WithEvents lblMinDosageValue As System.Windows.Forms.Label
    Friend WithEvents DosagesTableAdapter As VetDrugReference.VeterinaryDrugsDataSetTableAdapters.DosagesTableAdapter
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents HelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEditMode As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents txtMinDosage As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxDosage As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox

End Class
