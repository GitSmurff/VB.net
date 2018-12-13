<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Код_студентаLabel As System.Windows.Forms.Label
        Dim Дата_экзамена_1Label As System.Windows.Forms.Label
        Dim Код_предмета_1Label As System.Windows.Forms.Label
        Dim Оценка_1Label As System.Windows.Forms.Label
        Dim Дата_экзамена_2Label As System.Windows.Forms.Label
        Dim Код_предмета_2Label As System.Windows.Forms.Label
        Dim Оценка_2Label As System.Windows.Forms.Label
        Dim Дата_экзамена_3Label As System.Windows.Forms.Label
        Dim Код_предмета_3Label As System.Windows.Forms.Label
        Dim Оценка_3Label As System.Windows.Forms.Label
        Dim Средний_баллLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentsDataSet = New StudentsDB.StudentsDataSet()
        Me.ОценкиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОценкиTableAdapter = New StudentsDB.StudentsDataSetTableAdapters.ОценкиTableAdapter()
        Me.TableAdapterManager = New StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager()
        Me.ОценкиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ОценкиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Код_студентаTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_экзамена_1DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_предмета_1TextBox = New System.Windows.Forms.TextBox()
        Me.Оценка_1TextBox = New System.Windows.Forms.TextBox()
        Me.Дата_экзамена_2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_предмета_2TextBox = New System.Windows.Forms.TextBox()
        Me.Оценка_2TextBox = New System.Windows.Forms.TextBox()
        Me.Дата_экзамена_3DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Код_предмета_3TextBox = New System.Windows.Forms.TextBox()
        Me.Оценка_3TextBox = New System.Windows.Forms.TextBox()
        Me.Средний_баллTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Код_студентаLabel = New System.Windows.Forms.Label()
        Дата_экзамена_1Label = New System.Windows.Forms.Label()
        Код_предмета_1Label = New System.Windows.Forms.Label()
        Оценка_1Label = New System.Windows.Forms.Label()
        Дата_экзамена_2Label = New System.Windows.Forms.Label()
        Код_предмета_2Label = New System.Windows.Forms.Label()
        Оценка_2Label = New System.Windows.Forms.Label()
        Дата_экзамена_3Label = New System.Windows.Forms.Label()
        Код_предмета_3Label = New System.Windows.Forms.Label()
        Оценка_3Label = New System.Windows.Forms.Label()
        Средний_баллLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОценкиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОценкиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ОценкиBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Код_студентаLabel
        '
        Код_студентаLabel.AutoSize = True
        Код_студентаLabel.Location = New System.Drawing.Point(93, 95)
        Код_студентаLabel.Name = "Код_студентаLabel"
        Код_студентаLabel.Size = New System.Drawing.Size(77, 13)
        Код_студентаLabel.TabIndex = 4
        Код_студентаLabel.Text = "Код студента:"
        '
        'Дата_экзамена_1Label
        '
        Дата_экзамена_1Label.AutoSize = True
        Дата_экзамена_1Label.Location = New System.Drawing.Point(72, 122)
        Дата_экзамена_1Label.Name = "Дата_экзамена_1Label"
        Дата_экзамена_1Label.Size = New System.Drawing.Size(98, 13)
        Дата_экзамена_1Label.TabIndex = 5
        Дата_экзамена_1Label.Text = "Дата экзамена 1:"
        '
        'Код_предмета_1Label
        '
        Код_предмета_1Label.AutoSize = True
        Код_предмета_1Label.Location = New System.Drawing.Point(80, 148)
        Код_предмета_1Label.Name = "Код_предмета_1Label"
        Код_предмета_1Label.Size = New System.Drawing.Size(90, 13)
        Код_предмета_1Label.TabIndex = 6
        Код_предмета_1Label.Text = "Код предмета 1:"
        '
        'Оценка_1Label
        '
        Оценка_1Label.AutoSize = True
        Оценка_1Label.Location = New System.Drawing.Point(113, 174)
        Оценка_1Label.Name = "Оценка_1Label"
        Оценка_1Label.Size = New System.Drawing.Size(57, 13)
        Оценка_1Label.TabIndex = 8
        Оценка_1Label.Text = "Оценка 1:"
        '
        'Дата_экзамена_2Label
        '
        Дата_экзамена_2Label.AutoSize = True
        Дата_экзамена_2Label.Location = New System.Drawing.Point(72, 204)
        Дата_экзамена_2Label.Name = "Дата_экзамена_2Label"
        Дата_экзамена_2Label.Size = New System.Drawing.Size(98, 13)
        Дата_экзамена_2Label.TabIndex = 10
        Дата_экзамена_2Label.Text = "Дата экзамена 2:"
        '
        'Код_предмета_2Label
        '
        Код_предмета_2Label.AutoSize = True
        Код_предмета_2Label.Location = New System.Drawing.Point(80, 232)
        Код_предмета_2Label.Name = "Код_предмета_2Label"
        Код_предмета_2Label.Size = New System.Drawing.Size(90, 13)
        Код_предмета_2Label.TabIndex = 12
        Код_предмета_2Label.Text = "Код предмета 2:"
        '
        'Оценка_2Label
        '
        Оценка_2Label.AutoSize = True
        Оценка_2Label.Location = New System.Drawing.Point(113, 264)
        Оценка_2Label.Name = "Оценка_2Label"
        Оценка_2Label.Size = New System.Drawing.Size(57, 13)
        Оценка_2Label.TabIndex = 14
        Оценка_2Label.Text = "Оценка 2:"
        '
        'Дата_экзамена_3Label
        '
        Дата_экзамена_3Label.AutoSize = True
        Дата_экзамена_3Label.Location = New System.Drawing.Point(72, 288)
        Дата_экзамена_3Label.Name = "Дата_экзамена_3Label"
        Дата_экзамена_3Label.Size = New System.Drawing.Size(98, 13)
        Дата_экзамена_3Label.TabIndex = 16
        Дата_экзамена_3Label.Text = "Дата экзамена 3:"
        '
        'Код_предмета_3Label
        '
        Код_предмета_3Label.AutoSize = True
        Код_предмета_3Label.Location = New System.Drawing.Point(80, 314)
        Код_предмета_3Label.Name = "Код_предмета_3Label"
        Код_предмета_3Label.Size = New System.Drawing.Size(90, 13)
        Код_предмета_3Label.TabIndex = 18
        Код_предмета_3Label.Text = "Код предмета 3:"
        '
        'Оценка_3Label
        '
        Оценка_3Label.AutoSize = True
        Оценка_3Label.Location = New System.Drawing.Point(113, 344)
        Оценка_3Label.Name = "Оценка_3Label"
        Оценка_3Label.Size = New System.Drawing.Size(57, 13)
        Оценка_3Label.TabIndex = 20
        Оценка_3Label.Text = "Оценка 3:"
        '
        'Средний_баллLabel
        '
        Средний_баллLabel.AutoSize = True
        Средний_баллLabel.Location = New System.Drawing.Point(90, 372)
        Средний_баллLabel.Name = "Средний_баллLabel"
        Средний_баллLabel.Size = New System.Drawing.Size(80, 13)
        Средний_баллLabel.TabIndex = 22
        Средний_баллLabel.Text = "Средний балл:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(46, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Таблица ""Оценки"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentsDataSet
        '
        Me.StudentsDataSet.DataSetName = "StudentsDataSet"
        Me.StudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ОценкиBindingSource
        '
        Me.ОценкиBindingSource.DataMember = "Оценки"
        Me.ОценкиBindingSource.DataSource = Me.StudentsDataSet
        '
        'ОценкиTableAdapter
        '
        Me.ОценкиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = StudentsDB.StudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ОценкиTableAdapter = Me.ОценкиTableAdapter
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.СпециальностиTableAdapter = Nothing
        Me.TableAdapterManager.СтудентыTableAdapter = Nothing
        '
        'ОценкиBindingNavigator
        '
        Me.ОценкиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ОценкиBindingNavigator.BindingSource = Me.ОценкиBindingSource
        Me.ОценкиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ОценкиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ОценкиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ОценкиBindingNavigatorSaveItem})
        Me.ОценкиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ОценкиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ОценкиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ОценкиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ОценкиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ОценкиBindingNavigator.Name = "ОценкиBindingNavigator"
        Me.ОценкиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ОценкиBindingNavigator.Size = New System.Drawing.Size(457, 25)
        Me.ОценкиBindingNavigator.TabIndex = 4
        Me.ОценкиBindingNavigator.Text = "BindingNavigator1"
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
        'ОценкиBindingNavigatorSaveItem
        '
        Me.ОценкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ОценкиBindingNavigatorSaveItem.Image = CType(resources.GetObject("ОценкиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ОценкиBindingNavigatorSaveItem.Name = "ОценкиBindingNavigatorSaveItem"
        Me.ОценкиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ОценкиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'Код_студентаTextBox
        '
        Me.Код_студентаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Код_студента", True))
        Me.Код_студентаTextBox.Location = New System.Drawing.Point(176, 92)
        Me.Код_студентаTextBox.Name = "Код_студентаTextBox"
        Me.Код_студентаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_студентаTextBox.TabIndex = 5
        '
        'Дата_экзамена_1DateTimePicker
        '
        Me.Дата_экзамена_1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОценкиBindingSource, "Дата_экзамена_1", True))
        Me.Дата_экзамена_1DateTimePicker.Location = New System.Drawing.Point(176, 118)
        Me.Дата_экзамена_1DateTimePicker.Name = "Дата_экзамена_1DateTimePicker"
        Me.Дата_экзамена_1DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_экзамена_1DateTimePicker.TabIndex = 6
        '
        'Код_предмета_1TextBox
        '
        Me.Код_предмета_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Код_предмета_1", True))
        Me.Код_предмета_1TextBox.Location = New System.Drawing.Point(176, 145)
        Me.Код_предмета_1TextBox.Name = "Код_предмета_1TextBox"
        Me.Код_предмета_1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_предмета_1TextBox.TabIndex = 7
        '
        'Оценка_1TextBox
        '
        Me.Оценка_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Оценка_1", True))
        Me.Оценка_1TextBox.Location = New System.Drawing.Point(176, 171)
        Me.Оценка_1TextBox.Name = "Оценка_1TextBox"
        Me.Оценка_1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Оценка_1TextBox.TabIndex = 9
        '
        'Дата_экзамена_2DateTimePicker
        '
        Me.Дата_экзамена_2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОценкиBindingSource, "Дата_экзамена_2", True))
        Me.Дата_экзамена_2DateTimePicker.Location = New System.Drawing.Point(176, 200)
        Me.Дата_экзамена_2DateTimePicker.Name = "Дата_экзамена_2DateTimePicker"
        Me.Дата_экзамена_2DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_экзамена_2DateTimePicker.TabIndex = 11
        '
        'Код_предмета_2TextBox
        '
        Me.Код_предмета_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Код_предмета_2", True))
        Me.Код_предмета_2TextBox.Location = New System.Drawing.Point(176, 229)
        Me.Код_предмета_2TextBox.Name = "Код_предмета_2TextBox"
        Me.Код_предмета_2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_предмета_2TextBox.TabIndex = 13
        '
        'Оценка_2TextBox
        '
        Me.Оценка_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Оценка_2", True))
        Me.Оценка_2TextBox.Location = New System.Drawing.Point(176, 257)
        Me.Оценка_2TextBox.Name = "Оценка_2TextBox"
        Me.Оценка_2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Оценка_2TextBox.TabIndex = 15
        '
        'Дата_экзамена_3DateTimePicker
        '
        Me.Дата_экзамена_3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ОценкиBindingSource, "Дата_экзамена_3", True))
        Me.Дата_экзамена_3DateTimePicker.Location = New System.Drawing.Point(176, 284)
        Me.Дата_экзамена_3DateTimePicker.Name = "Дата_экзамена_3DateTimePicker"
        Me.Дата_экзамена_3DateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Дата_экзамена_3DateTimePicker.TabIndex = 17
        '
        'Код_предмета_3TextBox
        '
        Me.Код_предмета_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Код_предмета_3", True))
        Me.Код_предмета_3TextBox.Location = New System.Drawing.Point(176, 311)
        Me.Код_предмета_3TextBox.Name = "Код_предмета_3TextBox"
        Me.Код_предмета_3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Код_предмета_3TextBox.TabIndex = 19
        '
        'Оценка_3TextBox
        '
        Me.Оценка_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Оценка_3", True))
        Me.Оценка_3TextBox.Location = New System.Drawing.Point(176, 341)
        Me.Оценка_3TextBox.Name = "Оценка_3TextBox"
        Me.Оценка_3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Оценка_3TextBox.TabIndex = 21
        '
        'Средний_баллTextBox
        '
        Me.Средний_баллTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ОценкиBindingSource, "Средний_балл", True))
        Me.Средний_баллTextBox.Location = New System.Drawing.Point(176, 369)
        Me.Средний_баллTextBox.Name = "Средний_баллTextBox"
        Me.Средний_баллTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Средний_баллTextBox.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Вычислить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Средний_баллLabel)
        Me.Controls.Add(Me.Средний_баллTextBox)
        Me.Controls.Add(Оценка_3Label)
        Me.Controls.Add(Me.Оценка_3TextBox)
        Me.Controls.Add(Код_предмета_3Label)
        Me.Controls.Add(Me.Код_предмета_3TextBox)
        Me.Controls.Add(Дата_экзамена_3Label)
        Me.Controls.Add(Me.Дата_экзамена_3DateTimePicker)
        Me.Controls.Add(Оценка_2Label)
        Me.Controls.Add(Me.Оценка_2TextBox)
        Me.Controls.Add(Код_предмета_2Label)
        Me.Controls.Add(Me.Код_предмета_2TextBox)
        Me.Controls.Add(Дата_экзамена_2Label)
        Me.Controls.Add(Me.Дата_экзамена_2DateTimePicker)
        Me.Controls.Add(Оценка_1Label)
        Me.Controls.Add(Me.Оценка_1TextBox)
        Me.Controls.Add(Код_предмета_1Label)
        Me.Controls.Add(Me.Код_предмета_1TextBox)
        Me.Controls.Add(Дата_экзамена_1Label)
        Me.Controls.Add(Me.Дата_экзамена_1DateTimePicker)
        Me.Controls.Add(Код_студентаLabel)
        Me.Controls.Add(Me.Код_студентаTextBox)
        Me.Controls.Add(Me.ОценкиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "Таблица ""Оценки"""
        CType(Me.StudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОценкиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОценкиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ОценкиBindingNavigator.ResumeLayout(False)
        Me.ОценкиBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents StudentsDataSet As StudentsDataSet
    Friend WithEvents ОценкиBindingSource As BindingSource
    Friend WithEvents ОценкиTableAdapter As StudentsDataSetTableAdapters.ОценкиTableAdapter
    Friend WithEvents TableAdapterManager As StudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ОценкиBindingNavigator As BindingNavigator
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
    Friend WithEvents ОценкиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Код_студентаTextBox As TextBox
    Friend WithEvents Дата_экзамена_1DateTimePicker As DateTimePicker
    Friend WithEvents Код_предмета_1TextBox As TextBox
    Friend WithEvents Оценка_1TextBox As TextBox
    Friend WithEvents Дата_экзамена_2DateTimePicker As DateTimePicker
    Friend WithEvents Код_предмета_2TextBox As TextBox
    Friend WithEvents Оценка_2TextBox As TextBox
    Friend WithEvents Дата_экзамена_3DateTimePicker As DateTimePicker
    Friend WithEvents Код_предмета_3TextBox As TextBox
    Friend WithEvents Оценка_3TextBox As TextBox
    Friend WithEvents Средний_баллTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
