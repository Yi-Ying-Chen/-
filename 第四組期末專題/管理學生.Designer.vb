<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 管理學生
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
        Dim 姓名Label As System.Windows.Forms.Label
        Dim 系級Label As System.Windows.Forms.Label
        Dim 電話Label As System.Windows.Forms.Label
        Dim 電子郵件Label As System.Windows.Forms.Label
        Dim 房號Label As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(管理學生))
        Me.學生BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.學生BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.學生BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.搜尋 = New System.Windows.Forms.ToolStripButton()
        Me.學生DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.學生TableAdapter = New 第四組期末專題.宿舍資料DataSetTableAdapters.學生TableAdapter()
        Me.TableAdapterManager = New 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.學號TextBox = New System.Windows.Forms.TextBox()
        Me.姓名TextBox = New System.Windows.Forms.TextBox()
        Me.系級TextBox = New System.Windows.Forms.TextBox()
        Me.電話TextBox = New System.Windows.Forms.TextBox()
        Me.電子郵件TextBox = New System.Windows.Forms.TextBox()
        Me.房號TextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        學號Label = New System.Windows.Forms.Label()
        姓名Label = New System.Windows.Forms.Label()
        系級Label = New System.Windows.Forms.Label()
        電話Label = New System.Windows.Forms.Label()
        電子郵件Label = New System.Windows.Forms.Label()
        房號Label = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.學生BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.學生BindingNavigator.SuspendLayout()
        CType(Me.學生BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.學生DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '學號Label
        '
        學號Label.AutoSize = True
        學號Label.BackColor = System.Drawing.Color.DarkOrange
        學號Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        學號Label.Location = New System.Drawing.Point(161, 294)
        學號Label.Name = "學號Label"
        學號Label.Size = New System.Drawing.Size(68, 21)
        學號Label.TabIndex = 28
        學號Label.Text = "學號:"
        學號Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '姓名Label
        '
        姓名Label.AutoSize = True
        姓名Label.BackColor = System.Drawing.Color.DarkOrange
        姓名Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        姓名Label.Location = New System.Drawing.Point(161, 334)
        姓名Label.Name = "姓名Label"
        姓名Label.Size = New System.Drawing.Size(68, 21)
        姓名Label.TabIndex = 29
        姓名Label.Text = "姓名:"
        姓名Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '系級Label
        '
        系級Label.AutoSize = True
        系級Label.BackColor = System.Drawing.Color.DarkOrange
        系級Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        系級Label.Location = New System.Drawing.Point(161, 373)
        系級Label.Name = "系級Label"
        系級Label.Size = New System.Drawing.Size(68, 21)
        系級Label.TabIndex = 30
        系級Label.Text = "系級:"
        系級Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '電話Label
        '
        電話Label.AutoSize = True
        電話Label.BackColor = System.Drawing.Color.DarkOrange
        電話Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        電話Label.Location = New System.Drawing.Point(161, 408)
        電話Label.Name = "電話Label"
        電話Label.Size = New System.Drawing.Size(68, 21)
        電話Label.TabIndex = 31
        電話Label.Text = "電話:"
        電話Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '電子郵件Label
        '
        電子郵件Label.AutoSize = True
        電子郵件Label.BackColor = System.Drawing.Color.DarkOrange
        電子郵件Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        電子郵件Label.Location = New System.Drawing.Point(115, 447)
        電子郵件Label.Name = "電子郵件Label"
        電子郵件Label.Size = New System.Drawing.Size(114, 21)
        電子郵件Label.TabIndex = 32
        電子郵件Label.Text = "電子郵件:"
        電子郵件Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '房號Label
        '
        房號Label.AutoSize = True
        房號Label.BackColor = System.Drawing.Color.DarkOrange
        房號Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        房號Label.Location = New System.Drawing.Point(161, 486)
        房號Label.Name = "房號Label"
        房號Label.Size = New System.Drawing.Size(68, 21)
        房號Label.TabIndex = 33
        房號Label.Text = "房號:"
        房號Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.DarkOrange
        IDLabel.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        IDLabel.Location = New System.Drawing.Point(183, 519)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(46, 21)
        IDLabel.TabIndex = 34
        IDLabel.Text = "ID:"
        IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '學生BindingNavigator
        '
        Me.學生BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.學生BindingNavigator.BindingSource = Me.學生BindingSource
        Me.學生BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.學生BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.學生BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.學生BindingNavigatorSaveItem, Me.ToolStripTextBox2, Me.ToolStripTextBox1, Me.搜尋})
        Me.學生BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.學生BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.學生BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.學生BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.學生BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.學生BindingNavigator.Name = "學生BindingNavigator"
        Me.學生BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.學生BindingNavigator.Size = New System.Drawing.Size(851, 25)
        Me.學生BindingNavigator.TabIndex = 0
        Me.學生BindingNavigator.Text = "BindingNavigator1"
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
        '學生BindingSource
        '
        Me.學生BindingSource.DataMember = "學生"
        Me.學生BindingSource.DataSource = Me.宿舍資料DataSet
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
        '學生BindingNavigatorSaveItem
        '
        Me.學生BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.學生BindingNavigatorSaveItem.Image = CType(resources.GetObject("學生BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.學生BindingNavigatorSaveItem.Name = "學生BindingNavigatorSaveItem"
        Me.學生BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.學生BindingNavigatorSaveItem.Text = "儲存資料"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Enabled = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox2.Text = "學生搜尋"
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
        '學生DataGridView
        '
        Me.學生DataGridView.AutoGenerateColumns = False
        Me.學生DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.學生DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.學生DataGridView.DataSource = Me.學生BindingSource
        Me.學生DataGridView.Location = New System.Drawing.Point(30, 58)
        Me.學生DataGridView.Name = "學生DataGridView"
        Me.學生DataGridView.RowTemplate.Height = 24
        Me.學生DataGridView.Size = New System.Drawing.Size(746, 220)
        Me.學生DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "學號"
        Me.DataGridViewTextBoxColumn1.HeaderText = "學號"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "姓名"
        Me.DataGridViewTextBoxColumn2.HeaderText = "姓名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "系級"
        Me.DataGridViewTextBoxColumn3.HeaderText = "系級"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "電話"
        Me.DataGridViewTextBoxColumn4.HeaderText = "電話"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "電子郵件"
        Me.DataGridViewTextBoxColumn7.HeaderText = "電子郵件"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "房號"
        Me.DataGridViewTextBoxColumn8.HeaderText = "房號"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        '學生TableAdapter
        '
        Me.學生TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.學生TableAdapter = Me.學生TableAdapter
        Me.TableAdapterManager.學生違規紀錄TableAdapter = Nothing
        Me.TableAdapterManager.寢室TableAdapter = Nothing
        Me.TableAdapterManager.管理員TableAdapter = Nothing
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(673, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "重新整理"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 559)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "學生資訊修改:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.學生BindingSource
        Me.ComboBox1.DisplayMember = "學號"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(235, 560)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.ValueMember = "學號"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.Location = New System.Drawing.Point(443, 423)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "刪除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(399, 534)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(443, 324)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "新增"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '學號TextBox
        '
        Me.學號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "學號", True))
        Me.學號TextBox.Location = New System.Drawing.Point(235, 294)
        Me.學號TextBox.Name = "學號TextBox"
        Me.學號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.學號TextBox.TabIndex = 29
        '
        '姓名TextBox
        '
        Me.姓名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "姓名", True))
        Me.姓名TextBox.Location = New System.Drawing.Point(235, 334)
        Me.姓名TextBox.Name = "姓名TextBox"
        Me.姓名TextBox.Size = New System.Drawing.Size(100, 22)
        Me.姓名TextBox.TabIndex = 30
        '
        '系級TextBox
        '
        Me.系級TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "系級", True))
        Me.系級TextBox.Location = New System.Drawing.Point(235, 372)
        Me.系級TextBox.Name = "系級TextBox"
        Me.系級TextBox.Size = New System.Drawing.Size(100, 22)
        Me.系級TextBox.TabIndex = 31
        '
        '電話TextBox
        '
        Me.電話TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "電話", True))
        Me.電話TextBox.Location = New System.Drawing.Point(235, 407)
        Me.電話TextBox.Name = "電話TextBox"
        Me.電話TextBox.Size = New System.Drawing.Size(100, 22)
        Me.電話TextBox.TabIndex = 32
        '
        '電子郵件TextBox
        '
        Me.電子郵件TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "電子郵件", True))
        Me.電子郵件TextBox.Location = New System.Drawing.Point(235, 446)
        Me.電子郵件TextBox.Name = "電子郵件TextBox"
        Me.電子郵件TextBox.Size = New System.Drawing.Size(170, 22)
        Me.電子郵件TextBox.TabIndex = 33
        '
        '房號TextBox
        '
        Me.房號TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "房號", True))
        Me.房號TextBox.Location = New System.Drawing.Point(235, 485)
        Me.房號TextBox.Name = "房號TextBox"
        Me.房號TextBox.Size = New System.Drawing.Size(100, 22)
        Me.房號TextBox.TabIndex = 34
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.學生BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(235, 519)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 35
        '
        '管理學生
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(851, 612)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(房號Label)
        Me.Controls.Add(Me.房號TextBox)
        Me.Controls.Add(電子郵件Label)
        Me.Controls.Add(Me.電子郵件TextBox)
        Me.Controls.Add(電話Label)
        Me.Controls.Add(Me.電話TextBox)
        Me.Controls.Add(系級Label)
        Me.Controls.Add(Me.系級TextBox)
        Me.Controls.Add(姓名Label)
        Me.Controls.Add(Me.姓名TextBox)
        Me.Controls.Add(學號Label)
        Me.Controls.Add(Me.學號TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.學生DataGridView)
        Me.Controls.Add(Me.學生BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "管理學生"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理學生"
        CType(Me.學生BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.學生BindingNavigator.ResumeLayout(False)
        Me.學生BindingNavigator.PerformLayout()
        CType(Me.學生BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.學生DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 宿舍資料DataSet As 宿舍資料DataSet
    Friend WithEvents 學生BindingSource As BindingSource
    Friend WithEvents 學生TableAdapter As 宿舍資料DataSetTableAdapters.學生TableAdapter
    Friend WithEvents TableAdapterManager As 宿舍資料DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 學生BindingNavigator As BindingNavigator
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
    Friend WithEvents 學生BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents 學生DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents 搜尋 As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents 學號TextBox As TextBox
    Friend WithEvents 姓名TextBox As TextBox
    Friend WithEvents 系級TextBox As TextBox
    Friend WithEvents 電話TextBox As TextBox
    Friend WithEvents 電子郵件TextBox As TextBox
    Friend WithEvents 房號TextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
End Class
