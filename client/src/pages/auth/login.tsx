import { LoginForm } from 'components';

const LoginPage = () => {
	return (
		<section className='space-y-16 w-full px-2 md:w-1/2 lg:w-1/3 xl:px-12'>
			<h1 className='text-center font-bold text-5xl capitalize text-primary'>login</h1>
			<LoginForm />
		</section>
	);
};

export default LoginPage;
