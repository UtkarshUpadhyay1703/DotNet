namespace Person;

class EmpComparer : IComparer<Employee>
{
    public int Compare(Employee e1, Employee e2)
    {
        if (e1.Id > e2.Id)
        {
            return 1;
        }
        else if (e1.Id < e2.Id)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
