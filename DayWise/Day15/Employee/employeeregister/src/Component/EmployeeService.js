import axios from "axios";

class EmployeeService{
    constructor(){
        this.baseUrl="http://localhost:5264";
    }
    GetAllEmployees(){
        // alert("Get");
        return axios.get(this.baseUrl+"/RegisterEmp");
    }
}
export default new EmployeeService();