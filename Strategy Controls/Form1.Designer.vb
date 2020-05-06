<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StratList = New System.Windows.Forms.ListBox()
        Me.DataSet1 = New Strategy_Controls.DataSet1()
        Me.StrategiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StrategiesTableAdapter = New Strategy_Controls.DataSet1TableAdapters.StrategiesTableAdapter()
        Me.StrategyDG = New System.Windows.Forms.DataGridView()
        Me.DataSet11 = New Strategy_Controls.DataSet1()
        Me.Strategies1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Strategies1TableAdapter = New Strategy_Controls.DataSet1TableAdapters.Strategies1TableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StratNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PortfolioAlgoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalcAlgoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StopLossAlgoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadorRatioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RecordHistDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PriceScaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadScaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LXADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SXADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceSensitivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mirror = New System.Windows.Forms.Button()
        Me.SaveData = New System.Windows.Forms.Button()
        Me.ErrorTB = New System.Windows.Forms.TextBox()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StrategiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StrategyDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Strategies1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StratList
        '
        Me.StratList.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StratList.DataSource = Me.Strategies1BindingSource
        Me.StratList.DisplayMember = "StratName"
        Me.StratList.ForeColor = System.Drawing.Color.White
        Me.StratList.FormattingEnabled = True
        Me.StratList.Location = New System.Drawing.Point(25, 55)
        Me.StratList.Name = "StratList"
        Me.StratList.Size = New System.Drawing.Size(130, 511)
        Me.StratList.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StrategiesBindingSource
        '
        Me.StrategiesBindingSource.DataMember = "Strategies"
        Me.StrategiesBindingSource.DataSource = Me.DataSet1
        '
        'StrategiesTableAdapter
        '
        Me.StrategiesTableAdapter.ClearBeforeFill = True
        '
        'StrategyDG
        '
        Me.StrategyDG.AllowUserToAddRows = False
        Me.StrategyDG.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        Me.StrategyDG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.StrategyDG.AutoGenerateColumns = False
        Me.StrategyDG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StrategyDG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.StrategyDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StrategyDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GroupDataGridViewTextBoxColumn, Me.StratNameDataGridViewTextBoxColumn, Me.PortfolioAlgoDataGridViewTextBoxColumn, Me.CalcAlgoDataGridViewTextBoxColumn, Me.StopLossAlgoDataGridViewTextBoxColumn, Me.SpreadorRatioDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn, Me.ActiveDataGridViewCheckBoxColumn, Me.RecordHistDataGridViewCheckBoxColumn, Me.PriceScaleDataGridViewTextBoxColumn, Me.SpreadScaleDataGridViewTextBoxColumn, Me.LEDataGridViewTextBoxColumn, Me.LEADataGridViewTextBoxColumn, Me.LXDataGridViewTextBoxColumn, Me.LXADataGridViewTextBoxColumn, Me.SEDataGridViewTextBoxColumn, Me.SEADataGridViewTextBoxColumn, Me.SXDataGridViewTextBoxColumn, Me.SXADataGridViewTextBoxColumn, Me.PriceSensitivityDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn})
        Me.StrategyDG.DataSource = Me.StrategiesBindingSource
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StrategyDG.DefaultCellStyle = DataGridViewCellStyle16
        Me.StrategyDG.Location = New System.Drawing.Point(173, 55)
        Me.StrategyDG.Name = "StrategyDG"
        Me.StrategyDG.Size = New System.Drawing.Size(1709, 511)
        Me.StrategyDG.TabIndex = 1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Strategies1BindingSource
        '
        Me.Strategies1BindingSource.DataMember = "Strategies1"
        Me.Strategies1BindingSource.DataSource = Me.DataSet11
        '
        'Strategies1TableAdapter
        '
        Me.Strategies1TableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 30
        '
        'GroupDataGridViewTextBoxColumn
        '
        Me.GroupDataGridViewTextBoxColumn.DataPropertyName = "Group"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.GroupDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.GroupDataGridViewTextBoxColumn.HeaderText = "Group"
        Me.GroupDataGridViewTextBoxColumn.Name = "GroupDataGridViewTextBoxColumn"
        '
        'StratNameDataGridViewTextBoxColumn
        '
        Me.StratNameDataGridViewTextBoxColumn.DataPropertyName = "StratName"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.StratNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
        Me.StratNameDataGridViewTextBoxColumn.HeaderText = "StratName"
        Me.StratNameDataGridViewTextBoxColumn.Name = "StratNameDataGridViewTextBoxColumn"
        '
        'PortfolioAlgoDataGridViewTextBoxColumn
        '
        Me.PortfolioAlgoDataGridViewTextBoxColumn.DataPropertyName = "PortfolioAlgo"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.PortfolioAlgoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
        Me.PortfolioAlgoDataGridViewTextBoxColumn.HeaderText = "PortfolioAlgo"
        Me.PortfolioAlgoDataGridViewTextBoxColumn.Name = "PortfolioAlgoDataGridViewTextBoxColumn"
        Me.PortfolioAlgoDataGridViewTextBoxColumn.Width = 150
        '
        'CalcAlgoDataGridViewTextBoxColumn
        '
        Me.CalcAlgoDataGridViewTextBoxColumn.DataPropertyName = "CalcAlgo"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CalcAlgoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.CalcAlgoDataGridViewTextBoxColumn.HeaderText = "CalcAlgo"
        Me.CalcAlgoDataGridViewTextBoxColumn.Name = "CalcAlgoDataGridViewTextBoxColumn"
        Me.CalcAlgoDataGridViewTextBoxColumn.Width = 80
        '
        'StopLossAlgoDataGridViewTextBoxColumn
        '
        Me.StopLossAlgoDataGridViewTextBoxColumn.DataPropertyName = "StopLossAlgo"
        Me.StopLossAlgoDataGridViewTextBoxColumn.HeaderText = "SLAlgo"
        Me.StopLossAlgoDataGridViewTextBoxColumn.Name = "StopLossAlgoDataGridViewTextBoxColumn"
        Me.StopLossAlgoDataGridViewTextBoxColumn.Width = 60
        '
        'SpreadorRatioDataGridViewTextBoxColumn
        '
        Me.SpreadorRatioDataGridViewTextBoxColumn.DataPropertyName = "Spread_or_Ratio"
        Me.SpreadorRatioDataGridViewTextBoxColumn.HeaderText = "S or R"
        Me.SpreadorRatioDataGridViewTextBoxColumn.Name = "SpreadorRatioDataGridViewTextBoxColumn"
        Me.SpreadorRatioDataGridViewTextBoxColumn.Width = 50
        '
        'DirectionDataGridViewTextBoxColumn
        '
        Me.DirectionDataGridViewTextBoxColumn.DataPropertyName = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.HeaderText = "Direct"
        Me.DirectionDataGridViewTextBoxColumn.Name = "DirectionDataGridViewTextBoxColumn"
        Me.DirectionDataGridViewTextBoxColumn.Width = 50
        '
        'ActiveDataGridViewCheckBoxColumn
        '
        Me.ActiveDataGridViewCheckBoxColumn.DataPropertyName = "Active"
        Me.ActiveDataGridViewCheckBoxColumn.HeaderText = "Act"
        Me.ActiveDataGridViewCheckBoxColumn.Name = "ActiveDataGridViewCheckBoxColumn"
        Me.ActiveDataGridViewCheckBoxColumn.Width = 30
        '
        'RecordHistDataGridViewCheckBoxColumn
        '
        Me.RecordHistDataGridViewCheckBoxColumn.DataPropertyName = "RecordHist"
        Me.RecordHistDataGridViewCheckBoxColumn.HeaderText = "Rec"
        Me.RecordHistDataGridViewCheckBoxColumn.Name = "RecordHistDataGridViewCheckBoxColumn"
        Me.RecordHistDataGridViewCheckBoxColumn.Width = 30
        '
        'PriceScaleDataGridViewTextBoxColumn
        '
        Me.PriceScaleDataGridViewTextBoxColumn.DataPropertyName = "PriceScale"
        Me.PriceScaleDataGridViewTextBoxColumn.HeaderText = "PScale"
        Me.PriceScaleDataGridViewTextBoxColumn.Name = "PriceScaleDataGridViewTextBoxColumn"
        Me.PriceScaleDataGridViewTextBoxColumn.Width = 50
        '
        'SpreadScaleDataGridViewTextBoxColumn
        '
        Me.SpreadScaleDataGridViewTextBoxColumn.DataPropertyName = "SpreadScale"
        Me.SpreadScaleDataGridViewTextBoxColumn.HeaderText = "SScale"
        Me.SpreadScaleDataGridViewTextBoxColumn.Name = "SpreadScaleDataGridViewTextBoxColumn"
        Me.SpreadScaleDataGridViewTextBoxColumn.Width = 60
        '
        'LEDataGridViewTextBoxColumn
        '
        Me.LEDataGridViewTextBoxColumn.DataPropertyName = "LE"
        Me.LEDataGridViewTextBoxColumn.HeaderText = "LE"
        Me.LEDataGridViewTextBoxColumn.Name = "LEDataGridViewTextBoxColumn"
        Me.LEDataGridViewTextBoxColumn.Width = 60
        '
        'LEADataGridViewTextBoxColumn
        '
        Me.LEADataGridViewTextBoxColumn.DataPropertyName = "LEA"
        Me.LEADataGridViewTextBoxColumn.HeaderText = "LEA"
        Me.LEADataGridViewTextBoxColumn.Name = "LEADataGridViewTextBoxColumn"
        Me.LEADataGridViewTextBoxColumn.Width = 60
        '
        'LXDataGridViewTextBoxColumn
        '
        Me.LXDataGridViewTextBoxColumn.DataPropertyName = "LX"
        Me.LXDataGridViewTextBoxColumn.HeaderText = "LX"
        Me.LXDataGridViewTextBoxColumn.Name = "LXDataGridViewTextBoxColumn"
        Me.LXDataGridViewTextBoxColumn.Width = 60
        '
        'LXADataGridViewTextBoxColumn
        '
        Me.LXADataGridViewTextBoxColumn.DataPropertyName = "LXA"
        Me.LXADataGridViewTextBoxColumn.HeaderText = "LXA"
        Me.LXADataGridViewTextBoxColumn.Name = "LXADataGridViewTextBoxColumn"
        Me.LXADataGridViewTextBoxColumn.Width = 60
        '
        'SEDataGridViewTextBoxColumn
        '
        Me.SEDataGridViewTextBoxColumn.DataPropertyName = "SE"
        Me.SEDataGridViewTextBoxColumn.HeaderText = "SE"
        Me.SEDataGridViewTextBoxColumn.Name = "SEDataGridViewTextBoxColumn"
        Me.SEDataGridViewTextBoxColumn.Width = 60
        '
        'SEADataGridViewTextBoxColumn
        '
        Me.SEADataGridViewTextBoxColumn.DataPropertyName = "SEA"
        Me.SEADataGridViewTextBoxColumn.HeaderText = "SEA"
        Me.SEADataGridViewTextBoxColumn.Name = "SEADataGridViewTextBoxColumn"
        Me.SEADataGridViewTextBoxColumn.Width = 60
        '
        'SXDataGridViewTextBoxColumn
        '
        Me.SXDataGridViewTextBoxColumn.DataPropertyName = "SX"
        Me.SXDataGridViewTextBoxColumn.HeaderText = "SX"
        Me.SXDataGridViewTextBoxColumn.Name = "SXDataGridViewTextBoxColumn"
        Me.SXDataGridViewTextBoxColumn.Width = 60
        '
        'SXADataGridViewTextBoxColumn
        '
        Me.SXADataGridViewTextBoxColumn.DataPropertyName = "SXA"
        Me.SXADataGridViewTextBoxColumn.HeaderText = "SXA"
        Me.SXADataGridViewTextBoxColumn.Name = "SXADataGridViewTextBoxColumn"
        Me.SXADataGridViewTextBoxColumn.Width = 60
        '
        'PriceSensitivityDataGridViewTextBoxColumn
        '
        Me.PriceSensitivityDataGridViewTextBoxColumn.DataPropertyName = "PriceSensitivity"
        Me.PriceSensitivityDataGridViewTextBoxColumn.HeaderText = "Sens"
        Me.PriceSensitivityDataGridViewTextBoxColumn.Name = "PriceSensitivityDataGridViewTextBoxColumn"
        Me.PriceSensitivityDataGridViewTextBoxColumn.Width = 50
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.NotesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.Width = 300
        '
        'Mirror
        '
        Me.Mirror.BackColor = System.Drawing.Color.SteelBlue
        Me.Mirror.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Mirror.Location = New System.Drawing.Point(173, 12)
        Me.Mirror.Name = "Mirror"
        Me.Mirror.Size = New System.Drawing.Size(111, 30)
        Me.Mirror.TabIndex = 2
        Me.Mirror.Text = "Mirror"
        Me.Mirror.UseVisualStyleBackColor = False
        '
        'SaveData
        '
        Me.SaveData.BackColor = System.Drawing.Color.DarkRed
        Me.SaveData.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveData.Location = New System.Drawing.Point(1771, 19)
        Me.SaveData.Name = "SaveData"
        Me.SaveData.Size = New System.Drawing.Size(111, 30)
        Me.SaveData.TabIndex = 3
        Me.SaveData.Text = "Save Data"
        Me.SaveData.UseVisualStyleBackColor = False
        '
        'ErrorTB
        '
        Me.ErrorTB.BackColor = System.Drawing.Color.DimGray
        Me.ErrorTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorTB.ForeColor = System.Drawing.Color.White
        Me.ErrorTB.Location = New System.Drawing.Point(25, 581)
        Me.ErrorTB.Name = "ErrorTB"
        Me.ErrorTB.Size = New System.Drawing.Size(1857, 20)
        Me.ErrorTB.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1894, 961)
        Me.Controls.Add(Me.ErrorTB)
        Me.Controls.Add(Me.SaveData)
        Me.Controls.Add(Me.Mirror)
        Me.Controls.Add(Me.StrategyDG)
        Me.Controls.Add(Me.StratList)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Strategy Controls V1.01"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StrategiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StrategyDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Strategies1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StratList As System.Windows.Forms.ListBox
    Friend WithEvents DataSet1 As Strategy_Controls.DataSet1
    Friend WithEvents StrategiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StrategiesTableAdapter As Strategy_Controls.DataSet1TableAdapters.StrategiesTableAdapter
    Friend WithEvents StrategyDG As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet11 As Strategy_Controls.DataSet1
    Friend WithEvents Strategies1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Strategies1TableAdapter As Strategy_Controls.DataSet1TableAdapters.Strategies1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StratNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PortfolioAlgoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalcAlgoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StopLossAlgoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpreadorRatioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RecordHistDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PriceScaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpreadScaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LEADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LXADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SXADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceSensitivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mirror As System.Windows.Forms.Button
    Friend WithEvents SaveData As System.Windows.Forms.Button
    Friend WithEvents ErrorTB As System.Windows.Forms.TextBox

End Class
