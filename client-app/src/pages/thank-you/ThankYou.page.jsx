import { Container, Paper, Typography } from '@material-ui/core';
import React from 'react';
import useStyles from './ThankYou';

const ThankYou = () => {
  const classes = useStyles();
  return (
    <Container className={classes.container}>
      <Paper className={classes.paper}>
        <div className={classes.thankyou}>
          <Typography variant='h2'>Thank you</Typography>
        </div>
      </Paper>
    </Container>
  );
};

export default ThankYou;
