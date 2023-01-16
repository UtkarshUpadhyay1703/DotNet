import {BrowserRouter as Router,Route,Switch} from "react-router-dom";
import AddNishant from "./Component/AddNishant";
import Display from "./Component/Display";
import UpdateNishant from "./Component/UpdateNishant";
import DisplayById from "./Component/DisplayById";
function App() {
  return (
    <div>
      <Router>
        <Switch>
          <Route path="/Nishant"exact component={Display}></Route>
          <Route path="/Nishant/AddNishant" component={AddNishant}></Route>
          <Route path="/Nishant/UpdateNishant" component={UpdateNishant}></Route>
          <Route path="/Nishant/DisplayById" component={DisplayById}></Route>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
