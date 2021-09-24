import React, { Component } from 'react';
import {Category} from './Category';
import axios from 'axios';

export class Home extends Component {
  constructor(props) {
    super(props);
    this.state = {
      categories: [],
      isFetching: false
    }

    this.fetchCategories = this.fetchCategories.bind(this);
  }

  fetchCategories() {
      this.setState({...this.state, isFetching: true});
      axios.get("https://localhost:44393/api/categories").then(response => {
        this.setState({categories: response.data, isFetching: false});
      })
      .catch(e => {
      console.log(e);
      this.setState({...this.state, isFetching: false});
    });
  }
  
  componentDidMount() {
    this.fetchCategories()
  }

  render () {
    return (
      <div>
        {
          this.state.categories.map((category, index) => <Category key={index} category={category}></Category>)
        }
      </div>
    );
  }
}
