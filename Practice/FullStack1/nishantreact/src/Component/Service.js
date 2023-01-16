import axios from "axios";

class Service{
    constructor(){
        this.url="http://localhost:5063/Nishant";
    }
    GetAllNishant(){
        return axios.get(this.url);
    }
    AddNishant(nishantob){
        return axios.post(this.url,nishantob);
    }
    DeleteNishant(id){
        return axios.delete(this.url+"/"+id);
    }
}
export default new Service();