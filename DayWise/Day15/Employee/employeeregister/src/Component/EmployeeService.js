import axios from "axios";

class EmployeeService{
    constructor(){
        this.baseUrl="localhost:5264";
    }
    GetAllEmployees(){
        return axios.get(this.baseUrl+"/registeremp");
    }
}
export default new EmployeeService();