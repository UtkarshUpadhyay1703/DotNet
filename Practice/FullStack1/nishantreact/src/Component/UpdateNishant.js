import { useState } from "react"
import { useHistory } from "react-router-dom";
import Service from "./Service";

const UpdateNishant=()=>{
    let [nishantob,setnishantob]=useState({});
    let history=useHistory();
    var Change=(event)=>{
        var {name,value}=event.target
        setnishantob({...nishantob,[name]:value});
    }
    const Update=(event)=>{
        Service.UpdataNishant(nishantob.id,nishantob).then((resp)=>{
            console.log(resp);
            history.push("/Nishant");
        })
    }
    return(
        <div>
        <form>
            Enter Id: <input id="id" name="id" value={nishantob.id} onChange={Change}></input>
            Enter Name: <input id="name" name="name" value={nishantob.name} onChange={Change}></input>
            Enter Email: <input id="email" name="email" value={nishantob.email} onChange={Change}></input>
            <button type="button" id="btn" name="btn" onClick={Update}>Update</button>
        </form>
    </div>
    )
}
export default UpdateNishant;