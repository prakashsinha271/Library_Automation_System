<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdReport
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rptBookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryDataDataSet = New LibraryAutomationSystem_2._0.LibraryDataDataSet()
        Me.rptMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptIssueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptReturnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rptFineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JournalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptBookTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptBookTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptMemberTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptMemberTableAdapter()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptIssueTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptIssueTableAdapter()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptReturnTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptReturnTableAdapter()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.JournalsTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.JournalsTableAdapter()
        Me.ReportViewer7 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PurchaseOrderTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.PurchaseOrderTableAdapter()
        Me.ReportViewer8 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptFineTableAdapter = New LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptFineTableAdapter()
        CType(Me.rptBookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptIssueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptReturnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rptFineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptBookBindingSource
        '
        Me.rptBookBindingSource.DataMember = "rptBook"
        Me.rptBookBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'LibraryDataDataSet
        '
        Me.LibraryDataDataSet.DataSetName = "LibraryDataDataSet"
        Me.LibraryDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rptMemberBindingSource
        '
        Me.rptMemberBindingSource.DataMember = "rptMember"
        Me.rptMemberBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'rptIssueBindingSource
        '
        Me.rptIssueBindingSource.DataMember = "rptIssue"
        Me.rptIssueBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'rptReturnBindingSource
        '
        Me.rptReturnBindingSource.DataMember = "rptReturn"
        Me.rptReturnBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'rptFineBindingSource
        '
        Me.rptFineBindingSource.DataMember = "rptFine"
        Me.rptFineBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'JournalsBindingSource
        '
        Me.JournalsBindingSource.DataMember = "Journals"
        Me.JournalsBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "PurchaseOrder"
        Me.PurchaseOrderBindingSource.DataSource = Me.LibraryDataDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Today", "7 days", "15 days", "30 Days", "All"})
        Me.ComboBox3.Location = New System.Drawing.Point(561, 15)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 31)
        Me.ComboBox3.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(982, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 35)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Go Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(767, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Generate Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BookGeneral", "BookBank", "Issue Book", "Return Book", "Payed Fine", "Skip Fine", "Employee", "Student", "Journals", "Purchase Order"})
        Me.ComboBox1.Location = New System.Drawing.Point(355, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 31)
        Me.ComboBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(159, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Filter Report Format:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.rptBookBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptBook.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer1.TabIndex = 20
        '
        'rptBookTableAdapter
        '
        Me.rptBookTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.rptMemberBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptMembers.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer2.TabIndex = 21
        '
        'rptMemberTableAdapter
        '
        Me.rptMemberTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer3
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.rptIssueBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptIssue.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer3.TabIndex = 22
        '
        'rptIssueTableAdapter
        '
        Me.rptIssueTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer4
        '
        ReportDataSource4.Name = "DataSet1"
        ReportDataSource4.Value = Me.rptReturnBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptReturn.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer4.TabIndex = 23
        '
        'rptReturnTableAdapter
        '
        Me.rptReturnTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer5
        '
        ReportDataSource5.Name = "DataSet1"
        ReportDataSource5.Value = Me.rptFineBindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptFine.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer5.TabIndex = 24
        '
        'ReportViewer6
        '
        ReportDataSource6.Name = "DataSet1"
        ReportDataSource6.Value = Me.JournalsBindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptJournals.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer6.TabIndex = 25
        '
        'JournalsTableAdapter
        '
        Me.JournalsTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer7
        '
        ReportDataSource7.Name = "DataSet1"
        ReportDataSource7.Value = Me.PurchaseOrderBindingSource
        Me.ReportViewer7.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer7.LocalReport.ReportEmbeddedResource = "LibraryAutomationSystem_2._0.rptPurchaseOrder.rdlc"
        Me.ReportViewer7.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer7.Name = "ReportViewer7"
        Me.ReportViewer7.Size = New System.Drawing.Size(1011, 636)
        Me.ReportViewer7.TabIndex = 26
        '
        'PurchaseOrderTableAdapter
        '
        Me.PurchaseOrderTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer8
        '
        Me.ReportViewer8.Location = New System.Drawing.Point(170, 53)
        Me.ReportViewer8.Name = "ReportViewer8"
        Me.ReportViewer8.Size = New System.Drawing.Size(1011, 635)
        Me.ReportViewer8.TabIndex = 27
        '
        'rptFineTableAdapter
        '
        Me.rptFineTableAdapter.ClearBeforeFill = True
        '
        'AdReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryAutomationSystem_2._0.My.Resources.Resources.Ad_Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1346, 726)
        Me.Controls.Add(Me.ReportViewer7)
        Me.Controls.Add(Me.ReportViewer6)
        Me.Controls.Add(Me.ReportViewer5)
        Me.Controls.Add(Me.ReportViewer4)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer8)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "AdReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdReport"
        CType(Me.rptBookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptIssueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptReturnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rptFineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptBookBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryDataDataSet As LibraryAutomationSystem_2._0.LibraryDataDataSet
    Friend WithEvents rptBookTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptBookTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptMemberBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptMemberTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptMemberTableAdapter
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptIssueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptIssueTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptIssueTableAdapter
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptReturnBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptReturnTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptReturnTableAdapter
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents JournalsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JournalsTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.JournalsTableAdapter
    Friend WithEvents ReportViewer7 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PurchaseOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrderTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.PurchaseOrderTableAdapter
    Friend WithEvents ReportViewer8 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents rptFineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rptFineTableAdapter As LibraryAutomationSystem_2._0.LibraryDataDataSetTableAdapters.rptFineTableAdapter
End Class
