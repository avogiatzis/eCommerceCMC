import React from 'react';
import ShoppingCartIcon from '@material-ui/icons/ShoppingCart';
import AppBar from '@material-ui/core/AppBar';
import { Badge, IconButton, Toolbar, Typography } from '@material-ui/core';
import useStyles from './Layout.styles';
import { withRouter } from 'react-router-dom';
import { useSelector } from 'react-redux';
import {selectCartItemsCount} from '../redux/cart/cart.selectors'
import HomeIcon from '@material-ui/icons/Home';


const Layout = ({ children, history }) => {
  const classes = useStyles();
  const cartItemsCount = useSelector(selectCartItemsCount);

  const handleClick = ()=>{
    history.push('/cart')
  }
  return (
    <div className={classes.container}>
      <AppBar position='static'>
        <Toolbar>
        <IconButton onClick={()=>history.push('/')} color='inherit'><HomeIcon /></IconButton>
          <Typography
            variant='h6'
            color='inherit'
            className={`${classes.layoutTitle} ${classes.grow}`}
          >
            e-Commerce
          </Typography>
          <IconButton color='inherit' onClick={handleClick}>
            <Badge badgeContent={cartItemsCount} color='secondary'>
              <ShoppingCartIcon />
            </Badge>
          </IconButton>
        </Toolbar>
      </AppBar>
      <div className={classes.container}>{children}</div>
    </div>
  );
};

export default withRouter(Layout);
