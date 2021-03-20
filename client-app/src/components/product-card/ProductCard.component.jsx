import {
  Button,
  Card,
  CardContent,
  CardMedia,
  Typography,
} from '@material-ui/core';
import React from 'react';
import { useDispatch } from 'react-redux';
import useStyles from './ProductCard.styles';

const ProductCard = ({ product }) => {
  const classes = useStyles();
    const dispatch = useDispatch();
  const handleClick= ()=>{
    dispatch({
        type: 'ADD_ITEM',
        payload: product
      })
  }
  return (
    <Card className={classes.card}>
      <CardMedia className={classes.media} image={`${product.image}`} />

      <CardContent className={classes.content}>
      <div className={classes.details}>
        <Typography variant='h5' component='h2'>
          {product.name}
        </Typography>
        <Typography className={classes.pos} color='textSecondary'>
          {product.category}
        </Typography>
        <Typography className={classes.price}>${product.price}</Typography>
        </div>
        <Button
          variant='contained'
          color='primary'
          className={classes.addToCart}
          onClick={handleClick}
        >
          Add to cart
        </Button>
      </CardContent>


 
    </Card>
  );
};

export default ProductCard;
