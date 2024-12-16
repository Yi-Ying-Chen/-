<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 管理寢室
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim 房號Label As System.Windows.Forms.Label
        Dim 入住人數Label As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(管理寢室))
        Me.寢室BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.寢室BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.宿舍資料DataSet = New 第四組期末專題.宿舍資料DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.寢室BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.搜尋 = New System.Windows.Forms.ToolStripButton()
        Me.寢室DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.寢室TableAdapter = New 第四組期末專題.宿舍資料DataSetTableAdapters.寢室TableAdapter()
        Me.TableAdapterManager = New 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager()
        Me.管理員BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.管理員TableAdapter = New 第四組期末專題.宿舍資料DataSetTableAdapters.管理員TableAdapter()
        Me.房號TextBox = New System.Windows.Forms.TextBox()
        Me.入住人數TextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        房號Label = New System.Windows.Forms.Label()
        入住人數Label = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.寢室BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.寢室BindingNavigator.SuspendLayout()
        CType(Me.寢室BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.寢室DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.管理員BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '房號Label
        '
        房號Label.AutoSize = True
        房號Label.BackColor = System.Drawing.Color.CornflowerBlue
        房號Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        房號Label.Location = New System.Drawing.Point(127, 291)
        房號Label.Name = "房號Label"
        房號Label.Size = New System.Drawing.Size(68, 21)
        房號Label.TabIndex = 12
        房號Label.Text = "房號:"
        房號Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '入住人數Label
        '
        入住人數Label.AutoSize = True
        入住人數Label.BackColor = System.Drawing.Color.CornflowerBlue
        入住人數Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        入住人數Label.Location = New System.Drawing.Point(82, 327)
        入住人數Label.Name = "入住人數Label"
        入住人數Label.Size = New System.Drawing.Size(114, 21)
        入住人數Label.TabIndex = 13
        入住人數Label.Text = "入住人數:"
        入住人數Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.CornflowerBlue
        IDLabel.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        IDLabel.Location = New System.Drawing.Point(151, 370)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(46, 21)
        IDLabel.TabIndex = 14
        IDLabel.Text = "ID:"
        IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '寢室BindingNavigator
        '
        Me.寢室BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.寢室BindingNavigator.BindingSource = Me.寢室BindingSource
        Me.寢室BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.寢室BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.寢室BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.寢室BindingNavigatorSaveItem, Me.ToolStripTextBox2, Me.ToolStripTextBox1, Me.搜尋})
        Me.寢室BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.寢室BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.寢室BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.寢室BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.寢室BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.寢室BindingNavigator.Name = "寢室BindingNavigator"
        Me.寢室BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.寢室BindingNavigator.Size = New System.Drawing.Size(570, 25)
        Me.寢室BindingNavigator.TabIndex = 0
        Me.寢室BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "加入新的"
        '
        '寢室BindingSource
        '
        Me.寢室BindingSource.DataMember = "寢室"
        Me.寢室BindingSource.DataSource = Me.宿舍資料DataSet
        '
        '宿舍資料DataSet
        '
        Me.宿舍資料DataSet.DataSetName = "宿舍資料DataSet"
        Me.宿舍資料DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(27, 22)
        Me.BindingNavigatorCountItem.Text = "/{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目總數"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "刪除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "移到最前面"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一個"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "目前的位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一個"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "移到最後面"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '寢室BindingNavigatorSaveItem
        '
        Me.寢室BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.寢室BindingNavigatorSaveItem.Image = CType(resources.GetObject("寢室BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.寢室BindingNavigatorSaveItem.Name = "寢室BindingNavigatorSaveItem"
        Me.寢室BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.寢室BindingNavigatorSaveItem.Text = "儲存資料"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BackColor = System.Drawing.Color.White
        Me.ToolStripTextBox2.Enabled = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox2.Text = "寢室搜尋"
        Me.ToolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        '搜尋
        '
        Me.搜尋.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.搜尋.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.搜尋.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.搜尋.Name = "搜尋"
        Me.搜尋.Size = New System.Drawing.Size(35, 22)
        Me.搜尋.Text = "搜尋"
        '
        '寢室DataGridView
        '
        Me.寢室DataGridView.AutoGenerateColumns = False
        Me.寢室DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.寢室DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.寢室DataGridView.DataSource = Me.寢室BindingSource
        Me.寢室DataGridView.Location = New System.Drawing.Point(86, 42)
        Me.寢室DataGridView.Name = "寢室DataGridView"
        Me.寢室DataGridView.RowTemplate.Height = 24
        Me.寢室DataGridView.Size = New System.Drawing.Size(344, 220)
        Me.寢室DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "房號"
        Me.DataGridViewTextBoxColumn1.HeaderText = "房號"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "入住人數"
        Me.DataGridViewTextBoxColumn2.HeaderText = "入住人數"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(456, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "重新整理"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(344, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "新增"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(344, 426)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.Location = New System.Drawing.Point(344, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "刪除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        '寢室TableAdapter
        '
        Me.寢室TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.學生TableAdapter = Nothing
        Me.TableAdapterManager.學生違規紀錄TableAdapter = Nothing
        Me.TableAdapterManager.寢室TableAdapter = Me.寢室TableAdapter
        Me.TableAdapterManager.管理員TableAdapter = Nothing
        '
        '管理員BindingSource
        '
        Me.管理員BindingSource.DataMember = "管理員"
        Me.管理員BindingSource.DataSource = Me.宿舍資料DataSet
        '
        '管理員TableAdapter
        '
        Me.管理員TableAdapter.ClearBeforeFill = True
        '
        '房號TextBox
        '
        Me.房號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.寢室BindingSource, "房號", True))
        Me.房號TextBox.Location = New System.Drawing.Point(204, 291)
        Me.房號TextBox.Name = "房號TextBox"
        Me.房號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.房號TextBox.TabIndex = 13
        '
        '入住人數TextBox
        '
        Me.入住人數TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.寢室BindingSource, "入住人數", True))
        Me.入住人數TextBox.Location = New System.Drawing.Point(204, 327)
        Me.入住人數TextBox.Name = "入住人數TextBox"
        Me.入住人數TextBox.Size = New System.Drawing.Size(100, 22)
        Me.入住人數TextBox.TabIndex = 14
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.寢室BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(204, 370)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.寢室BindingSource
        Me.ComboBox1.DisplayMember = "房號"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(183, 429)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 16
        Me.ComboBox1.ValueMember = "房號"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "寢室資訊修改:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '管理寢室
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(570, 508)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(入住人數Label)
        Me.Controls.Add(Me.入住人數TextBox)
        Me.Controls.Add(房號Label)
        Me.Controls.Add(Me.房號TextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.寢室DataGridView)
        Me.Controls.Add(Me.寢室BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "管理寢室"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理寢室"
        CType(Me.寢室BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.寢室BindingNavigator.ResumeLayout(False)
        Me.寢室BindingNavigator.PerformLayout()
        CType(Me.寢室BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.寢室DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.管理員BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 宿舍資料DataSet As 宿舍資料DataSet
    Friend WithEvents 寢室BindingSource As BindingSource
    Friend WithEvents 寢室TableAdapter As 宿舍資料DataSetTableAdapters.寢室TableAdapter
    Friend WithEvents TableAdapterManager As 宿舍資料DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 寢室BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents 寢室BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents 搜尋 As ToolStripButton
    Friend WithEvents 寢室DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents 管理員BindingSource As BindingSource
    Friend WithEvents 管理員TableAdapter As 宿舍資料DataSetTableAdapters.管理員TableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents 房號TextBox As TextBox
    Friend WithEvents 入住人數TextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
End Class
