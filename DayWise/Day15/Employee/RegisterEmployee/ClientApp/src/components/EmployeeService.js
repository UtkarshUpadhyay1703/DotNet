import axios from "axios";

class EmployeeService{
    constructor(){
        this.baseUrl="http://localhost:5264";
    }
    GetAllEmployees(){
        return axios.get(this.baseUrl+"/RegisterEmp");
    }
}
export default new EmployeeService();