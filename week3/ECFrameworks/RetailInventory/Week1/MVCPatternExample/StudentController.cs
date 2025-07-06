public class StudentController
{
    private Student _model;
    private StudentView _view;

    public StudentController(Student model, StudentView view)
    {
        _model = model;
        _view = view;
    }

    public void SetStudentName(string name)
    {
        _model.Name = name;
    }

    public void SetStudentRollNo(string rollNo)
    {
        _model.RollNo = rollNo;
    }

    public void UpdateView()
    {
        _view.DisplayStudentDetails(_model.Name, _model.RollNo);
    }
}
