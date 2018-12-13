<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ФИОLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim Дата_рожденияLabel As System.Windows.Forms.Label
        Dim РодителиLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim ТелефонLabel As System.Windows.Forms.Label
        Dim Паспортные_данныеLabel As System.Windows.Forms.Label
        Dim Номер_зачёткиLabel As System.Windows.Forms.Label
        Dim Дата_поступленияLabel As System.Windows.Forms.Label
        Dim ГруппаLabel As System.Windows.Forms.Label
        Dim КурсLabel As System.Windows.Forms.Label
        Dim Очная_форма_обученияLabel As System.Windows.Forms.Label
        Dim Код_специальностиLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.СтудентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsDataSet = New StudentsDB.StudentsDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.СтудентыTableAdapter = New StudentsDB.StudentsDataSetTableAdapters.СтудентыTableAdapter()
        Me.TableAdapterManager = New StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.СтудентыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.СтудентыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_рожденияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_поступленияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ГруппаTextBox = New System.Windows.Forms.TextBox()
        Me.Очная_форма_обученияCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Код_специальностиComboBox = New System.Windows.Forms.ComboBox()
        Me.СпециальностиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.СпециальностиTableAdapter = New StudentsDB.StudentsDataSetTableAdapters.СпециальностиTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        ФИОLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        Дата_рожденияLabel = New System.Windows.Forms.Label()
        РодителиLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        ТелефонLabel = New System.Windows.Forms.Label()
        Паспортные_данныеLabel = New System.Windows.Forms.Label()
        Номер_зачёткиLabel = New System.Windows.Forms.Label()
        Дата_поступленияLabel = New System.Windows.Forms.Label()
        ГруппаLabel = New System.Windows.Forms.Label()
        КурсLabel = New System.Windows.Forms.Label()
        Очная_форма_обученияLabel = New System.Windows.Forms.Label()
        Код_специальностиLabel1 = New System.Windows.Forms.Label()
        CType(Me.СтудентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтудентыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СтудентыBindingNavigator.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Location = New System.Drawing.Point(94, 81)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(37, 13)
        ФИОLabel.TabIndex = 3
        ФИОLabel.Text = "ФИО:"
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Location = New System.Drawing.Point(101, 111)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(30, 13)
        ПолLabel.TabIndex = 4
        ПолLabel.Text = "Пол:"
        '
        'Дата_рожденияLabel
        '
        Дата_рожденияLabel.AutoSize = True
        Дата_рожденияLabel.Location = New System.Drawing.Point(42, 142)
        Дата_рожденияLabel.Name = "Дата_рожденияLabel"
        Дата_рожденияLabel.Size = New System.Drawing.Size(89, 13)
        Дата_рожденияLabel.TabIndex = 6
        Дата_рожденияLabel.Text = "Дата рождения:"
        '
        'РодителиLabel
        '
        РодителиLabel.AutoSize = True
        РодителиLabel.Location = New System.Drawing.Point(73, 172)
        РодителиLabel.Name = "РодителиLabel"
        РодителиLabel.Size = New System.Drawing.Size(58, 13)
        РодителиLabel.TabIndex = 8
        РодителиLabel.Text = "Родители:"
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(90, 196)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(41, 13)
        АдресLabel.TabIndex = 10
        АдресLabel.Text = "Адрес:"
        '
        'ТелефонLabel
        '
        ТелефонLabel.AutoSize = True
        ТелефонLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Телефон", True))
        ТелефонLabel.Location = New System.Drawing.Point(76, 224)
        ТелефонLabel.Name = "ТелефонLabel"
        ТелефонLabel.Size = New System.Drawing.Size(55, 13)
        ТелефонLabel.TabIndex = 12
        ТелефонLabel.Text = "Телефон:"
        '
        'СтудентыBindingSource
        '
        Me.СтудентыBindingSource.DataMember = "Студенты"
        Me.СтудентыBindingSource.DataSource = Me.StudentsDataSet
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Паспортные_данныеLabel
        '
        Паспортные_данныеLabel.AutoSize = True
        Паспортные_данныеLabel.Location = New System.Drawing.Point(17, 253)
        Паспортные_данныеLabel.Name = "Паспортные_данныеLabel"
        Паспортные_данныеLabel.Size = New System.Drawing.Size(114, 13)
        Паспортные_данныеLabel.TabIndex = 14
        Паспортные_данныеLabel.Text = "Паспортные данные:"
        '
        'Номер_зачёткиLabel
        '
        Номер_зачёткиLabel.AutoSize = True
        Номер_зачёткиLabel.Location = New System.Drawing.Point(44, 281)
        Номер_зачёткиLabel.Name = "Номер_зачёткиLabel"
        Номер_зачёткиLabel.Size = New System.Drawing.Size(87, 13)
        Номер_зачёткиLabel.TabIndex = 16
        Номер_зачёткиLabel.Text = "Номер зачётки:"
        '
        'Дата_поступленияLabel
        '
        Дата_поступленияLabel.AutoSize = True
        Дата_поступленияLabel.Location = New System.Drawing.Point(28, 312)
        Дата_поступленияLabel.Name = "Дата_поступленияLabel"
        Дата_поступленияLabel.Size = New System.Drawing.Size(103, 13)
        Дата_поступленияLabel.TabIndex = 18
        Дата_поступленияLabel.Text = "Дата поступления:"
        '
        'ГруппаLabel
        '
        ГруппаLabel.AutoSize = True
        ГруппаLabel.Location = New System.Drawing.Point(86, 338)
        ГруппаLabel.Name = "ГруппаLabel"
        ГруппаLabel.Size = New System.Drawing.Size(45, 13)
        ГруппаLabel.TabIndex = 20
        ГруппаLabel.Text = "Группа:"
        '
        'КурсLabel
        '
        КурсLabel.AutoSize = True
        КурсLabel.Location = New System.Drawing.Point(97, 365)
        КурсLabel.Name = "КурсLabel"
        КурсLabel.Size = New System.Drawing.Size(34, 13)
        КурсLabel.TabIndex = 22
        КурсLabel.Text = "Курс:"
        '
        'Очная_форма_обученияLabel
        '
        Очная_форма_обученияLabel.AutoSize = True
        Очная_форма_обученияLabel.Location = New System.Drawing.Point(4, 428)
        Очная_форма_обученияLabel.Name = "Очная_форма_обученияLabel"
        Очная_форма_обученияLabel.Size = New System.Drawing.Size(127, 13)
        Очная_форма_обученияLabel.TabIndex = 26
        Очная_форма_обученияLabel.Text = "Очная форма обучения:"
        '
        'Код_специальностиLabel1
        '
        Код_специальностиLabel1.AutoSize = True
        Код_специальностиLabel1.Location = New System.Drawing.Point(22, 394)
        Код_специальностиLabel1.Name = "Код_специальностиLabel1"
        Код_специальностиLabel1.Size = New System.Drawing.Size(109, 13)
        Код_специальностиLabel1.TabIndex = 40
        Код_специальностиLabel1.Text = "Код специальности:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Таблица ""Студенты"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'СтудентыTableAdapter
        '
        Me.СтудентыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностиTableAdapter = Nothing
        Me.TableAdapterManager.СтудентыTableAdapter = Me.СтудентыTableAdapter
        '
        'СтудентыBindingNavigator
        '
        Me.СтудентыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СтудентыBindingNavigator.BindingSource = Me.СтудентыBindingSource
        Me.СтудентыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СтудентыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СтудентыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СтудентыBindingNavigatorSaveItem})
        Me.СтудентыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СтудентыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СтудентыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СтудентыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СтудентыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СтудентыBindingNavigator.Name = "СтудентыBindingNavigator"
        Me.СтудентыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СтудентыBindingNavigator.Size = New System.Drawing.Size(505, 25)
        Me.СтудентыBindingNavigator.TabIndex = 3
        Me.СтудентыBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
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
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'СтудентыBindingNavigatorSaveItem
        '
        Me.СтудентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СтудентыBindingNavigatorSaveItem.Image = CType(resources.GetObject("СтудентыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СтудентыBindingNavigatorSaveItem.Name = "СтудентыBindingNavigatorSaveItem"
        Me.СтудентыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.СтудентыBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "ФИО", True))
        Me.ФИОTextBox.Location = New System.Drawing.Point(137, 78)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ФИОTextBox.TabIndex = 4
        '
        'Дата_рожденияDateTimePicker
        '
        Me.Дата_рожденияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СтудентыBindingSource, "Дата_рождения", True))
        Me.Дата_рожденияDateTimePicker.Location = New System.Drawing.Point(137, 138)
        Me.Дата_рожденияDateTimePicker.Name = "Дата_рожденияDateTimePicker"
        Me.Дата_рожденияDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_рожденияDateTimePicker.TabIndex = 7
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(137, 193)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(100, 20)
        Me.АдресTextBox.TabIndex = 11
        '
        'Дата_поступленияDateTimePicker
        '
        Me.Дата_поступленияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СтудентыBindingSource, "Дата_поступления", True))
        Me.Дата_поступленияDateTimePicker.Location = New System.Drawing.Point(137, 308)
        Me.Дата_поступленияDateTimePicker.Name = "Дата_поступленияDateTimePicker"
        Me.Дата_поступленияDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_поступленияDateTimePicker.TabIndex = 19
        '
        'ГруппаTextBox
        '
        Me.ГруппаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Группа", True))
        Me.ГруппаTextBox.Location = New System.Drawing.Point(137, 335)
        Me.ГруппаTextBox.Name = "ГруппаTextBox"
        Me.ГруппаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ГруппаTextBox.TabIndex = 21
        '
        'Очная_форма_обученияCheckBox
        '
        Me.Очная_форма_обученияCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.СтудентыBindingSource, "Очная_форма_обучения", True))
        Me.Очная_форма_обученияCheckBox.Location = New System.Drawing.Point(137, 423)
        Me.Очная_форма_обученияCheckBox.Name = "Очная_форма_обученияCheckBox"
        Me.Очная_форма_обученияCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Очная_форма_обученияCheckBox.TabIndex = 27
        Me.Очная_форма_обученияCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(262, 466)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(20, 510)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 23)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(137, 510)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(262, 510)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(137, 557)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Телефон", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(138, 224)
        Me.MaskedTextBox1.Mask = "+7(999) 000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 35
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Паспортные_данные", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(138, 253)
        Me.MaskedTextBox2.Mask = "0000-000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 36
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Номер_зачётки", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(138, 281)
        Me.MaskedTextBox3.Mask = "00000"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox3.TabIndex = 37
        Me.MaskedTextBox3.ValidatingType = GetType(Integer)
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.СтудентыBindingSource, "Курс", True))
        Me.NumericUpDown1.Location = New System.Drawing.Point(137, 363)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 38
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Пол", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Мужской", "Женский"})
        Me.ComboBox1.Location = New System.Drawing.Point(137, 108)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 39
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Родители", True))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Отец и Мать", "Мать", "Отец", "Нет"})
        Me.ComboBox2.Location = New System.Drawing.Point(138, 166)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 40
        '
        'Код_специальностиComboBox
        '
        Me.Код_специальностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтудентыBindingSource, "Код_специальности", True))
        Me.Код_специальностиComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.СтудентыBindingSource, "Код_специальности", True))
        Me.Код_специальностиComboBox.DataSource = Me.СпециальностиBindingSource
        Me.Код_специальностиComboBox.DisplayMember = "Наименование_специальности"
        Me.Код_специальностиComboBox.FormattingEnabled = True
        Me.Код_специальностиComboBox.Location = New System.Drawing.Point(137, 391)
        Me.Код_специальностиComboBox.Name = "Код_специальностиComboBox"
        Me.Код_специальностиComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Код_специальностиComboBox.TabIndex = 41
        Me.Код_специальностиComboBox.ValueMember = "Код_специальности"
        '
        'СпециальностиBindingSource
        '
        Me.СпециальностиBindingSource.DataMember = "Специальности"
        Me.СпециальностиBindingSource.DataSource = Me.StudentsDataSet
        '
        'СпециальностиTableAdapter
        '
        Me.СпециальностиTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(25, 556)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 604)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Код_специальностиLabel1)
        Me.Controls.Add(Me.Код_специальностиComboBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Очная_форма_обученияLabel)
        Me.Controls.Add(Me.Очная_форма_обученияCheckBox)
        Me.Controls.Add(КурсLabel)
        Me.Controls.Add(ГруппаLabel)
        Me.Controls.Add(Me.ГруппаTextBox)
        Me.Controls.Add(Дата_поступленияLabel)
        Me.Controls.Add(Me.Дата_поступленияDateTimePicker)
        Me.Controls.Add(Номер_зачёткиLabel)
        Me.Controls.Add(Паспортные_данныеLabel)
        Me.Controls.Add(ТелефонLabel)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(РодителиLabel)
        Me.Controls.Add(Дата_рожденияLabel)
        Me.Controls.Add(Me.Дата_рожденияDateTimePicker)
        Me.Controls.Add(ПолLabel)
        Me.Controls.Add(ФИОLabel)
        Me.Controls.Add(Me.ФИОTextBox)
        Me.Controls.Add(Me.СтудентыBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "Таблица ""Студенты"""
        CType(Me.СтудентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтудентыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СтудентыBindingNavigator.ResumeLayout(False)
        Me.СтудентыBindingNavigator.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СпециальностиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StudentsDataSet As StudentsDataSet
    Friend WithEvents СтудентыBindingSource As BindingSource
    Friend WithEvents СтудентыTableAdapter As StudentsDataSetTableAdapters.СтудентыTableAdapter
    Friend WithEvents TableAdapterManager As StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СтудентыBindingNavigator As BindingNavigator
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
    Friend WithEvents СтудентыBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ФИОTextBox As TextBox
    Friend WithEvents Дата_рожденияDateTimePicker As DateTimePicker
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents Дата_поступленияDateTimePicker As DateTimePicker
    Friend WithEvents ГруппаTextBox As TextBox
    Friend WithEvents Очная_форма_обученияCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Код_специальностиComboBox As ComboBox
    Friend WithEvents СпециальностиBindingSource As BindingSource
    Friend WithEvents СпециальностиTableAdapter As StudentsDataSetTableAdapters.СпециальностиTableAdapter
    Friend WithEvents Button8 As Button
End Class
