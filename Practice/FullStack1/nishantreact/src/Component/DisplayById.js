import { useState } from "react"
import Service from "./Service";

const DisplayById=()=>{
    let [idob,setidob]=useState({});
    let [nishantob,setnishantob]=useState({});
    var Change=(event)=>{
        var {name,value}=event.target
        setidob({...idob,[name]:value});
    }
    var Search=(event)=>{
        Service.SearchNishant(idob.id).then((resp)=>{
            console.log(resp.data);
            setnishantob(resp.data);
        })
    }

    return(
        <div>
            Enter ID <input id="id" name="id" onChange={Change} value={idob.id}></input>
            <button id="btn" name="btn" onClick={Search}>Search</button>
            <table>
                <tr>
                    <th>ID :</th>
                    <th>Name :</th>
                    <th>Email :</th>
                </tr>
                <tr>
                    <td>{nishantob.id}</td>
                    <td>{nishantob.name}</td>
                    <td>{nishantob.email}</td>
                </tr>
            </table>
        </div>
    )
}
export default DisplayById;