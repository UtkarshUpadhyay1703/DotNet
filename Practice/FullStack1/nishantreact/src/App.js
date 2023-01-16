import {BrowserRouter as Router,Route,Switch} from "react-router-dom";
import AddNishant from "./Component/AddNishant";
import Display from "./Component/Display";
function App() {
  return (
    <div>
      <Router>
        <Switch>
          <Route path="/Nishant"exact component={Display}></Route>
          <Route path="/Nishant/AddNishant" component={AddNishant}></Route>
        </Switch>
      </Router>
    </div>
  );
}

export default App;
