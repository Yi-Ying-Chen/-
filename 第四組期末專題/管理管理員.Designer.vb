<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 管理管理員
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim 姓名Label As System.Windows.Forms.Label
        Dim 電話Label As System.Windows.Forms.Label
        Dim 電子郵件Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(管理管理員))
        Me.宿舍資料DataSet = New 第四組期末專題.宿舍資料DataSet()
        Me.管理員BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.管理員TableAdapter = New 第四組期末專題.宿舍資料DataSetTableAdapters.管理員TableAdapter()
        Me.TableAdapterManager = New 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager()
        Me.管理員BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.管理員BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.搜尋 = New System.Windows.Forms.ToolStripButton()
        Me.管理員DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.姓名TextBox = New System.Windows.Forms.TextBox()
        Me.電話TextBox = New System.Windows.Forms.TextBox()
        Me.電子郵件TextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        姓名Label = New System.Windows.Forms.Label()
        電話Label = New System.Windows.Forms.Label()
        電子郵件Label = New System.Windows.Forms.Label()
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.管理員BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.管理員BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.管理員BindingNavigator.SuspendLayout()
        CType(Me.管理員DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.MediumSpringGreen
        IDLabel.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        IDLabel.Location = New System.Drawing.Point(188, 271)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(46, 21)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '姓名Label
        '
        姓名Label.AutoSize = True
        姓名Label.BackColor = System.Drawing.Color.MediumSpringGreen
        姓名Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        姓名Label.Location = New System.Drawing.Point(166, 311)
        姓名Label.Name = "姓名Label"
        姓名Label.Size = New System.Drawing.Size(68, 21)
        姓名Label.TabIndex = 4
        姓名Label.Text = "姓名:"
        姓名Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '電話Label
        '
        電話Label.AutoSize = True
        電話Label.BackColor = System.Drawing.Color.MediumSpringGreen
        電話Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        電話Label.Location = New System.Drawing.Point(166, 356)
        電話Label.Name = "電話Label"
        電話Label.Size = New System.Drawing.Size(68, 21)
        電話Label.TabIndex = 6
        電話Label.Text = "電話:"
        電話Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '電子郵件Label
        '
        電子郵件Label.AutoSize = True
        電子郵件Label.BackColor = System.Drawing.Color.MediumSpringGreen
        電子郵件Label.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        電子郵件Label.Location = New System.Drawing.Point(120, 399)
        電子郵件Label.Name = "電子郵件Label"
        電子郵件Label.Size = New System.Drawing.Size(114, 21)
        電子郵件Label.TabIndex = 8
        電子郵件Label.Text = "電子郵件:"
        電子郵件Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '宿舍資料DataSet
        '
        Me.宿舍資料DataSet.DataSetName = "宿舍資料DataSet"
        Me.宿舍資料DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = 第四組期末專題.宿舍資料DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.學生TableAdapter = Nothing
        Me.TableAdapterManager.學生違規紀錄TableAdapter = Nothing
        Me.TableAdapterManager.寢室TableAdapter = Nothing
        Me.TableAdapterManager.管理員TableAdapter = Me.管理員TableAdapter
        '
        '管理員BindingNavigator
        '
        Me.管理員BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.管理員BindingNavigator.BindingSource = Me.管理員BindingSource
        Me.管理員BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.管理員BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.管理員BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.管理員BindingNavigatorSaveItem, Me.ToolStripTextBox2, Me.ToolStripTextBox1, Me.搜尋})
        Me.管理員BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.管理員BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.管理員BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.管理員BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.管理員BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.管理員BindingNavigator.Name = "管理員BindingNavigator"
        Me.管理員BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.管理員BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.管理員BindingNavigator.TabIndex = 0
        Me.管理員BindingNavigator.Text = "BindingNavigator1"
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
        '管理員BindingNavigatorSaveItem
        '
        Me.管理員BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.管理員BindingNavigatorSaveItem.Image = CType(resources.GetObject("管理員BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.管理員BindingNavigatorSaveItem.Name = "管理員BindingNavigatorSaveItem"
        Me.管理員BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.管理員BindingNavigatorSaveItem.Text = "儲存資料"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Enabled = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        Me.ToolStripTextBox2.Text = "管理員搜尋"
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
        '管理員DataGridView
        '
        Me.管理員DataGridView.AutoGenerateColumns = False
        Me.管理員DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.管理員DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.管理員DataGridView.DataSource = Me.管理員BindingSource
        Me.管理員DataGridView.Location = New System.Drawing.Point(135, 41)
        Me.管理員DataGridView.Name = "管理員DataGridView"
        Me.管理員DataGridView.RowTemplate.Height = 24
        Me.管理員DataGridView.Size = New System.Drawing.Size(446, 221)
        Me.管理員DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "電話"
        Me.DataGridViewTextBoxColumn3.HeaderText = "電話"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "電子郵件"
        Me.DataGridViewTextBoxColumn4.HeaderText = "電子郵件"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.管理員BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(240, 270)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextBox.TabIndex = 3
        '
        '姓名TextBox
        '
        Me.姓名TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.管理員BindingSource, "姓名", True))
        Me.姓名TextBox.Location = New System.Drawing.Point(240, 310)
        Me.姓名TextBox.Name = "姓名TextBox"
        Me.姓名TextBox.Size = New System.Drawing.Size(100, 22)
        Me.姓名TextBox.TabIndex = 5
        '
        '電話TextBox
        '
        Me.電話TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.管理員BindingSource, "電話", True))
        Me.電話TextBox.Location = New System.Drawing.Point(240, 355)
        Me.電話TextBox.Name = "電話TextBox"
        Me.電話TextBox.Size = New System.Drawing.Size(100, 22)
        Me.電話TextBox.TabIndex = 7
        '
        '電子郵件TextBox
        '
        Me.電子郵件TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.管理員BindingSource, "電子郵件", True))
        Me.電子郵件TextBox.Location = New System.Drawing.Point(240, 399)
        Me.電子郵件TextBox.Name = "電子郵件TextBox"
        Me.電子郵件TextBox.Size = New System.Drawing.Size(100, 22)
        Me.電子郵件TextBox.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.管理員BindingSource
        Me.ComboBox1.DisplayMember = "ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(240, 437)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 436)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 21)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "管理員資訊修改:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("標楷體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(629, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "重新整理"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button4.Location = New System.Drawing.Point(393, 338)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "刪除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.Location = New System.Drawing.Point(393, 426)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "修改"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(393, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "新增"
        Me.Button2.UseVisualStyleBackColor = True
        '
        '管理管理員
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(電子郵件Label)
        Me.Controls.Add(Me.電子郵件TextBox)
        Me.Controls.Add(電話Label)
        Me.Controls.Add(Me.電話TextBox)
        Me.Controls.Add(姓名Label)
        Me.Controls.Add(Me.姓名TextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.管理員DataGridView)
        Me.Controls.Add(Me.管理員BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "管理管理員"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理管理員"
        CType(Me.宿舍資料DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.管理員BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.管理員BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.管理員BindingNavigator.ResumeLayout(False)
        Me.管理員BindingNavigator.PerformLayout()
        CType(Me.管理員DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 宿舍資料DataSet As 宿舍資料DataSet
    Friend WithEvents 管理員BindingSource As BindingSource
    Friend WithEvents 管理員TableAdapter As 宿舍資料DataSetTableAdapters.管理員TableAdapter
    Friend WithEvents TableAdapterManager As 宿舍資料DataSetTableAdapters.TableAdapterManager
    Friend WithEvents 管理員BindingNavigator As BindingNavigator
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
    Friend WithEvents 管理員BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents 管理員DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents 搜尋 As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents 姓名TextBox As TextBox
    Friend WithEvents 電話TextBox As TextBox
    Friend WithEvents 電子郵件TextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
