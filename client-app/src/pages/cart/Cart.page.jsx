import { Button, IconButton, TableContainer } from '@material-ui/core';
import React, { useEffect, useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { selectCartItems } from '../../redux/cart/cart.selectors';
import Paper from '@material-ui/core/Paper';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import AddIcon from '@material-ui/icons/Add';
import RemoveIcon from '@material-ui/icons/Remove';
import DeleteIcon from '@material-ui/icons/Delete';
import agent from '../../api/agent.js';
import { withRouter } from 'react-router-dom';

const Cart = ({ history }) => {
  const cartItems = useSelector(selectCartItems);
  const dispatch = useDispatch();
  const [shipping, setShipping] = useState(0);
  const reducer = (totalCost, item) => totalCost + item.quantity * item.price;
  const totalCost = cartItems.reduce(reducer, 0);
  

  useEffect(() => {
    let mounted = true;
    const fetchData = async () => {
      const data = totalCost>0 ? await agent.ShippingCost.get(totalCost): 0;
      if (mounted) {
        await setShipping(data);
      }
    };
    fetchData();
    return function cleanup (){
        mounted=false;
    }
  }, [totalCost]);
  const handleSend = () => {
    dispatch({
      type: 'CLEAR_CART',
    });
    agent.Order.send(cartItems).then(() => history.push('/thankyou'));
  };
  return (
    <div>
      <TableContainer component={Paper}>
        <Table>
          <caption>
            Total Cost: ${totalCost} + Shipping: ${shipping}
          </caption>

          <TableHead>
            <TableRow>
              <TableCell>Product</TableCell>
              <TableCell>Category</TableCell>
              <TableCell>Quantity</TableCell>
              <TableCell>Price</TableCell>
              <TableCell></TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {cartItems.map((cartItem, idx) => (
              <TableRow key={idx}>
                <TableCell component='th' scope='row'>
                  {cartItem.name}
                </TableCell>
                <TableCell>{cartItem.category}</TableCell>
                <TableCell>
                  <IconButton
                    size='small'
                    disableRipple
                    onClick={() =>
                      dispatch({
                        type: 'ADD_ITEM',
                        payload: cartItem,
                      })
                    }
                  >
                    <AddIcon />
                  </IconButton>
                  {cartItem.quantity}

                  <IconButton
                    size='small'
                    disableRipple
                    onClick={() =>
                      dispatch({
                        type: 'REMOVE_ITEM',
                        payload: cartItem,
                      })
                    }
                  >
                    <RemoveIcon />
                  </IconButton>
                </TableCell>
                <TableCell>${cartItem.price * cartItem.quantity}</TableCell>
                <TableCell>
                  {' '}
                  <IconButton
                    size='small'
                    disableRipple
                    onClick={() =>
                      dispatch({
                        type: 'CLEAR_ITEM_FROM_CART',
                        payload: cartItem,
                      })
                    }
                  >
                    <DeleteIcon />
                  </IconButton>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Button color='primary' variant='contained' onClick={handleSend}>
        Send Order
      </Button>
    </div>
  );
};

export default withRouter(Cart);
