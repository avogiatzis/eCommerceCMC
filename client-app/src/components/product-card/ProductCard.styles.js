import { makeStyles } from '@material-ui/core';

const useStyles = makeStyles((theme) => ({
  card: {
    height: '100%',
    //position:'relative',
  },
  title: {
    fontSize: 14,
    marginBottom: 20,
  },
  pos: {
    marginBottom: 12,
  },
  media: {
    height: 0,
    paddingTop: '56.25%', // 16:9
  },
  price: {
    marginBottom: 30,
  },
  content: {
    minHeight: 215,
  },
  details: {
    minHeight: 125,
  },
}));

export default useStyles;
