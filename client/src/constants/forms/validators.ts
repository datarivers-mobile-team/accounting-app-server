import * as Yup from 'yup';

export const LOGIN_VALIDATOR = Yup.object({
	email: Yup.string().email().required('Email is required'),
	password: Yup.string().required('Password is required'),
});

export type LoginForm = Yup.InferType<typeof LOGIN_VALIDATOR>;
