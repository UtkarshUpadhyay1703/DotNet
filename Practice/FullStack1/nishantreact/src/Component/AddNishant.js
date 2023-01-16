import { useState } from "react";
import { useHistory } from "react-router-dom";
import Service from "./Service";

const AddNishant=()=>{
    let [nishantob,setnishantob]=useState({});
    var history=useHistory();
    const Change=(event)=>{
        var {name,value}=event.target
        setnishantob({...nishantob,[name]:value});
    }
    const Add=(event)=>{
        Service.AddNishant(nishantob).then((response)=>{
            console.log(response.data);
            history.push("/Nishant");
        });
    }
    return(
        <div>
            <form>
                Enter Id: <input id="id" name="id" value={nishantob.id} onChange={Change}></input>
                Enter Name: <input id="name" name="name" value={nishantob.name} onChange={Change}></input>
                Enter Email: <input id="email" name="email" value={nishantob.email} onChange={Change}></input>
                <button type="button" id="btn" name="btn" onClick={Add}>Add</button>
            </form>
        </div>
    )
}
export default AddNishant;