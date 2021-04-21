import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import { BrowserRouter, Route, Switch, Redirect } from "react-router-dom";

import AddTaskForm from './forms/AddTaskForm';
import EditTaskForm from './forms/EditTaskForm';
import ShortTasksTable from "./tables/ShortTasksTable";

ReactDOM.render(
  <BrowserRouter>
    <App>
      <Switch>
        <Route exact path="/">
          <Redirect to="/tasks" />
        </Route>
        <Route exact path='/tasks' component={ShortTasksTable}/>
        <Route path='/tasks/add' component={AddTaskForm} />
        <Route path='/task/:id(\d+)' component={EditTaskForm}/>
      </Switch>
    </App>
  </BrowserRouter>,
  document.getElementById('root')
);