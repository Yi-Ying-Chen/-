<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 管理學生違規紀錄
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim 學號Label As System.Windows.Forms.Label
        Dim 最近一次違規項目Label As System.Windows.Forms.Label
        Dim 最近一次違規時間Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(管理學生違規紀錄))
        Me.宿舍資料DataSet = New 第四組期末專題.宿舍資料DataSet()
        Me.學生違規紀錄BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.學生違規紀錄TableAdapter = New 第四組期末專題.宿舍資料DataSetTableAdapters.學生違規紀錄TableAdapter()
        Me.TableAdapterManager = New 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager()
        Me.學生違規紀錄BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.學生違規紀錄BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.搜尋 = New System.Windows.Forms.ToolStripButton()
        Me.學生違規紀錄DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.學號TextBox = New System.Windows.Forms.TextBox()
        Me.最近一次違規項目TextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.最近一次違規時間TextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        學號Label = New System.Windows.Forms.Label()
        最近一次違規項目Label = New System.Windows.Forms.Label()
        最近一次違規時間Label = New System.Windows.Forms.Label()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.學生違規紀錄BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.學生違規紀錄BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.學生違規紀錄BindingNavigator.SuspendLayout()
        CType(Me.學生違規紀錄DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '學號Label
        '
        學號Label.AutoSize = True
        學號Label.BackColor = System.Drawing.Color.HotPink
        學號Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        學號Label.Location = New System.Drawing.Point(193, 283)
        學號Label.Name = "學號Label"
        學號Label.Size = New System.Drawing.Size(68, 21)
        學號Label.TabIndex = 2
        學號Label.Text = "學號:"
        學號Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '最近一次違規項目Label
        '
        最近一次違規項目Label.AutoSize = True
        最近一次違規項目Label.BackColor = System.Drawing.Color.HotPink
        最近一次違規項目Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        最近一次違規項目Label.Location = New System.Drawing.Point(55, 317)
        最近一次違規項目Label.Name = "最近一次違規項目Label"
        最近一次違規項目Label.Size = New System.Drawing.Size(206, 21)
        最近一次違規項目Label.TabIndex = 4
        最近一次違規項目Label.Text = "最近一次違規項目:"
        最近一次違規項目Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '最近一次違規時間Label
        '
        最近一次違規時間Label.AutoSize = True
        最近一次違規時間Label.BackColor = System.Drawing.Color.HotPink
        最近一次違規時間Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        最近一次違規時間Label.Location = New System.Drawing.Point(55, 359)
        最近一次違規時間Label.Name = "最近一次違規時間Label"
        最近一次違規時間Label.Size = New System.Drawing.Size(206, 21)
        最近一次違規時間Label.TabIndex = 39
        最近一次違規時間Label.Text = "最近一次違規時間:"
        最近一次違規時間Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '宿舍資料DataSet
        '
        Me.宿舍資料DataSet.DataSetName = "宿舍資料DataSet"
        Me.宿舍資料DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '學生違規紀錄BindingSource
        '
        Me.學生違規紀錄BindingSource.DataMember = "學生違規紀錄"
        Me.學生違規紀錄BindingSource.DataSource = Me.宿舍資料DataSet
        '
        '學生違規紀錄TableAdapter
        '
        Me.學生違規紀錄TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.學生TableAdapter = Nothing
        Me.TableAdapterManager.學生違規紀錄TableAdapter = Me.學生違規紀錄TableAdapter
        Me.TableAdapterManager.寢室TableAdapter = Nothing
        Me.TableAdapterManager.管理員TableAdapter = Nothing
        '
        '學生違規紀錄BindingNavigator
        '
        Me.學生違規紀錄BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.學生違規紀錄BindingNavigator.BindingSource = Me.學生違規紀錄BindingSource
        Me.學生違規紀錄BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.學生違規紀錄BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.學生違規紀錄BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.學生違規紀錄BindingNavigatorSaveItem, Me.ToolStripTextBox2, Me.ToolStripTextBox1, Me.搜尋})
        Me.學生違規紀錄BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.學生違規紀錄BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.學生違規紀錄BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.學生違規紀錄BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.學生違規紀錄BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.學生違規紀錄BindingNavigator.Name = "學生違規紀錄BindingNavigator"
        Me.學生違規紀錄BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.學生違規紀錄BindingNavigator.Size = New System.Drawing.Size(729, 25)
        Me.學生違規紀錄BindingNavigator.TabIndex = 0
        Me.學生違規紀錄BindingNavigator.Text = "BindingNavigator1"
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
        '學生違規紀錄BindingNavigatorSaveItem
        '
        Me.學生違規紀錄BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.學生違規紀錄BindingNavigatorSaveItem.Image = CType(resources.GetObject("學生違規紀錄BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.學生違規紀錄BindingNavigatorSaveItem.Name = "學生違規紀錄BindingNavigatorSaveItem"
        Me.學生違規紀錄BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.學生違規紀錄BindingNavigatorSaveItem.Text = "儲存資料"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Enabled = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox2.Text = "違規紀錄搜尋"
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
        Me.搜尋.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.搜尋.Name = "搜尋"
        Me.搜尋.Size = New System.Drawing.Size(35, 22)
        Me.搜尋.Text = "搜尋"
        '
        '學生違規紀錄DataGridView
        '
        Me.學生違規紀錄DataGridView.AutoGenerateColumns = False
        Me.學生違規紀錄DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.學生違規紀錄DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.學生違規紀錄DataGridView.DataSource = Me.學生違規紀錄BindingSource
        Me.學生違規紀錄DataGridView.Location = New System.Drawing.Point(139, 44)
        Me.學生違規紀錄DataGridView.Name = "學生違規紀錄DataGridView"
        Me.學生違規紀錄DataGridView.RowTemplate.Height = 24
        Me.學生違規紀錄DataGridView.Size = New System.Drawing.Size(351, 220)
        Me.學生違規紀錄DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "學號"
        Me.DataGridViewTextBoxColumn1.HeaderText = "學號"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "最近一次違規項目"
        Me.DataGridViewTextBoxColumn2.HeaderText = "最近一次違規項目"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "最近一次違規時間"
        Me.DataGridViewTextBoxColumn3.HeaderText = "最近一次違規時間"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        '學號TextBox
        '
        Me.學號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生違規紀錄BindingSource, "學號", True))
        Me.學號TextBox.Location = New System.Drawing.Point(267, 283)
        Me.學號TextBox.Name = "學號TextBox"
        Me.學號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.學號TextBox.TabIndex = 3
        '
        '最近一次違規項目TextBox
        '
        Me.最近一次違規項目TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生違規紀錄BindingSource, "最近一次違規項目", True))
        Me.最近一次違規項目TextBox.Location = New System.Drawing.Point(267, 317)
        Me.最近一次違規項目TextBox.Name = "最近一次違規項目TextBox"
        Me.最近一次違規項目TextBox.Size = New System.Drawing.Size(184, 22)
        Me.最近一次違規項目TextBox.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(420, 399)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.HotPink
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "違規紀錄資訊修改:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.學生違規紀錄BindingSource
        Me.ComboBox1.DisplayMember = "學號"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(267, 402)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 33
        Me.ComboBox1.ValueMember = "學號"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(491, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "新增"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(557, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "重新整理"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.HotPink
        Me.Label2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "格式:yyyymmdd"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '最近一次違規時間TextBox
        '
        Me.最近一次違規時間TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生違規紀錄BindingSource, "最近一次違規時間", True))
        Me.最近一次違規時間TextBox.Location = New System.Drawing.Point(267, 359)
        Me.最近一次違規時間TextBox.Name = "最近一次違規時間TextBox"
        Me.最近一次違規時間TextBox.Size = New System.Drawing.Size(121, 22)
        Me.最近一次違規時間TextBox.TabIndex = 40
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.Location = New System.Drawing.Point(541, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "刪除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        '管理學生違規紀錄
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 475)
        Me.Controls.Add(最近一次違規時間Label)
        Me.Controls.Add(Me.最近一次違規時間TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(最近一次違規項目Label)
        Me.Controls.Add(Me.最近一次違規項目TextBox)
        Me.Controls.Add(學號Label)
        Me.Controls.Add(Me.學號TextBox)
        Me.Controls.Add(Me.學生違規紀錄DataGridView)
        Me.Controls.Add(Me.學生違規紀錄BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "管理學生違規紀錄"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理學生違規紀錄"
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.學生違規紀錄BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.學生違規紀錄BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.學生違規紀錄BindingNavigator.ResumeLayout(False)
        Me.學生違規紀錄BindingNavigator.PerformLayout()
        CType(Me.學生違規紀錄DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 宿舍資料DataSet As 宿舍資料DataSet
    Friend WithEvents 學生違規紀錄BindingSource As BindingSource
    Friend WithEvents 學生違規紀錄TableAdapter As 宿舍資料DataSetTableAdapters.學生違規紀錄TableAdapter
    Friend WithEvents TableAdapterManager As 宿舍資料DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 學生違規紀錄BindingNavigator As BindingNavigator
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
    Friend WithEvents 學生違規紀錄BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents 學生違規紀錄DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents 搜尋 As ToolStripButton
    Friend WithEvents 學號TextBox As TextBox
    Friend WithEvents 最近一次違規項目TextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents 最近一次違規時間TextBox As TextBox
    Friend WithEvents Button4 As Button
End Class
