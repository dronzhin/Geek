package DZOOP7.Vacancies;

import java.util.ArrayList;
import java.util.List;

public abstract class Vacancy {
    public void setJobTitle(String jobTitle) {
        this.jobTitle = jobTitle;
    }

    private String jobTitle;
    private String description;
    private List<String> responsibilities;

    public Vacancy(String description) {
        this.description = description;
        responsibilities = new ArrayList<>();
    }
    public void addResponsibily(String responsibily){
        responsibilities.add(responsibily);
    }

    @Override
    public String toString() {
        String result = "";
        result += "Наименование вакансии - " + jobTitle + "\n";
        result += "Описание вакансии - " + description + "\n";
        String responsibility = "";
        for (String res: responsibilities) {
            responsibility += res + "\n";
        }
        result += "Обязанновсти: \n" + responsibility;
        return result;
    }

    public String getJobTitle() {
        return jobTitle;
    }
}
