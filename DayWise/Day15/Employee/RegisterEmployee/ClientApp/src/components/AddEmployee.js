import { useState } from "react"
import EmployeeService from "./EmployeeService";

const AddEmployee=()=>{
    let [Employee,setEmployee]=useState();
    const Change=(event)=>{
        var {name,value}=event.target
        setEmployee({...Employee,[name]:value});
    }
    const Add=(event)=>{
        EmployeeService.
    }
    return(
        <div>
            <form>
                Enter id <input id="id" name="id" value={emp.employee_id} onChange={Change}></input>
employee_name
employee_address
employee_mobile_no
employee_aadhar_no
employee_bank_account_no
employee_email_id
employee_password
name
address
mobile_no
aadhar_no
bank_account_no
email_id
password
            </form>
        </div>
    )
}