// import {BrowserRouter as Route,Router,Switch} from "react-router-dom";
import { BrowserRouter as Router,Switch,Route } from 'react-router-dom';
import DisplayAllEmployees from "./Component/DisplayAllEmployees";
function App() {
  return (
    <div>
    <Router>
    <Switch>
    <Route path="/RegisterEmp" exact component={DisplayAllEmployees}></Route>
    </Switch>
    </Router>
    {/* <DisplayAllEmployees></DisplayAllEmployees> */}
    </div>
  );
}

export default App;
