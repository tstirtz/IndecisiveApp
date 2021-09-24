import React, { Component } from 'react';
import { Collapse, Button, Card, CardBody, CardHeader, ListGroup, ListGroupItem } from 'reactstrap';

export class Category extends Component {
  constructor(props) {
    super(props);

    this.toggle = this.toggle.bind(this);
    this.randomize = this.randomize.bind(this);

    this.state = {
      isOpen: false,
      randomItem: ""
    }
  }

  toggle() {
    this.setState({...this.state, isOpen: !this.state.isOpen});
  }

  randomize() {
    const items = this.props.category.items;
    const randomIndex = Math.floor(Math.random() * items.length);
    this.setState({...this.state, randomItem: items[randomIndex]})
  }

  render () {
    return (
      <div>
        <Button color="primary" onClick={this.toggle} style={{ marginBottom: '1rem' }}>{this.props.category.title}</Button>
        <Collapse isOpen={this.state.isOpen}>
          <Card>
            <CardBody>
              <CardHeader>
                  {
                    this.state.randomItem &&
                     <span>{this.state.randomItem.title}</span>
                  }
                  <Button color="success" onClick={this.randomize}>Select Random</Button>
              </CardHeader>
              <CardBody>
                <ListGroup>
                  {
                    this.props.category.items.map((item, index) => <ListGroupItem key={index}>{item.title}</ListGroupItem>)
                  }
                </ListGroup>
              </CardBody>
            </CardBody>
          </Card>
        </Collapse>
      </div>
    );
  }
}
