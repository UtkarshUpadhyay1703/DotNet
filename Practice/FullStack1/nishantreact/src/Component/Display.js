import {useState,useEffect} from "react";
import Service from "./Service";
import { Link, useHistory } from "react-router-dom";
const Display=()=>{
    const [NishantArr,setNishantArr]=useState([]);
    const [flag,setflag]=useState(false);
    var history=useHistory();
    useEffect (()=>{
        Service.GetAllNishant().then((resp)=>{
            console.log(resp.data);
            setNishantArr(resp.data);
        });
    },[]);

    useEffect(()=>{
        Service.GetAllNishant().then((resp)=>{
            console.log(resp.data);
            setNishantArr(resp.data);
        }).catch((err) => {
            console.log("error occured", err);
        });
    },[flag]);

    const DeleteNishant=(id)=>{
        Service.DeleteNishant(id).then((resp)=>{
            console.log(resp.data);
            setflag(true);
        })
    }

    let Render=()=>{
        return NishantArr.map((Nish)=>{
            return <tr key={Nish.id}><td>{Nish.id}</td><td>{Nish.name}</td><td>{Nish.email}</td>
            <button type="button" name="btn" id="btn" onClick={()=>DeleteNishant(Nish.id)}>Delete</button> </tr>
        })
    }
    return(
        <div>
            <Link to="Nishant/AddNishant">
                <button id="b" name="b">Add Nishant</button>
                </Link>
                <Link to="Nishant/UpdateNishant">
                    <button id="update" name="update">Update Nishant</button>
                </Link>
                <Link to="Nishant/DisplayById">
                    <button id="id" name="id">DisplayById</button>
                </Link>
            <table>
                <tr>
                    <th>ID :</th>
                    <th>Name :</th>
                    <th>Email :</th>
                </tr>
                {Render()}
            </table>
        </div>
    )
}
export default Display;