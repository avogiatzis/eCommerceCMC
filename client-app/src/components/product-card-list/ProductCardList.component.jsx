import React, { useEffect, useState } from 'react';
import agent from '../../api/agent';
import { Grid} from '@material-ui/core';
import ProductCard from '../product-card/ProductCard.component';
import useStyles from './ProductCardList.styles'



const ProductCardList = () => {
  const classes = useStyles();
  const [products, setProducts] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const data = await agent.Products.list();
      await setProducts(data);
    };
    fetchData();
  }, []);

  return (
    <div className={classes.listContainer}>
      <Grid container spacing={3}>
        {products &&
          products.map((product) => (
            <Grid item key={product.id} xs={3}>
              <ProductCard product={product} />
            </Grid>
          ))}
      </Grid>
    </div>
  );
};

export default ProductCardList;
