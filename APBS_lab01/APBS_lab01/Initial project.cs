namespace APBS_lab01;

public class Initial_project
{
    private int newField;
    private string nameOfProject;

    public Initial_project(int newField, string nameOfProject)
    {
        this.newField = newField;
        this.nameOfProject = nameOfProject;
    }

    public int hashCode()
    {
        return newField + nameOfProject.Length + nameOfProject[0];
    }
}