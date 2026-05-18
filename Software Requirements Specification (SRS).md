# **Software Requirements Specification (SRS)**

## **Starter Package – Training & Consultancy Platform**

**1\. Project Overview**

The project is a modern web-based platform designed for:

- Online training/course selling
- Consultancy and construction service showcasing
- Project portfolio presentation
- Student account management
- Inquiry and contact management

The platform will allow users to purchase courses online, access enrolled course materials, and explore consultancy services and previous works.

An admin panel will be provided to manage website content, students, courses, projects, and inquiries.

# **2\. Project Objectives**

The main objectives of the platform are:

- Create a professional online presence for the company
- Sell recorded online courses
- Showcase consultancy and construction services
- Manage students and course access
- Handle online payments securely
- Provide centralized content management through an admin panel

#

#

#

# **3\. Scope of Work**

The Starter Package includes:

- Public business website
- Authentication system
- Course management
- Payment gateway integration
- Basic CMS (Content Management System)
- Dedicated admin panel
- Consultancy/project showcase section
- Contact and inquiry system

The Starter Package does not include:

- Advanced LMS features
- Live classes
- Batch management
- Certificates
- Quizzes/exams
- Advanced analytics/reporting

# **4\. User Roles**

The system will contain the following user roles:

## **4.1 Visitor**

A visitor can:

- Browse public pages
- View services
- View projects
- View course information
- Contact the company
- Register/login

## **4.2 Student**

A student can:

- Login to their account
- Access purchased courses
- Watch course videos
- View enrolled course list
- Update profile information

## **4.3 Admin**

An admin can:

- Manage users
- Manage students
- Manage courses
- Manage course access
- Manage projects/portfolio
- Manage website content
- Manage inquiries
- Manage payment records

# **5\. Functional Requirements**

# **5.1 Public Website**

The website shall include:

## **Home Page**

- Company introduction
- Hero/banner section
- Featured services
- Featured courses
- Featured projects
- Testimonials/partners section
- Contact call-to-action

## **Consultancy & Construction Page**

The page shall include:

- Consultancy services
- Interior design services
- Construction services
- Drawing/design services
- Previous works/projects
- Inquiry/contact option

## **Training/Course Page**

The page shall include:

- Course listing
- Course details
- Course pricing
- Enrollment/purchase option
- Instructor or organization details

## **Project Showcase Page**

The page shall include:

- Project images
- Description
- Support/services information
- Pricing information (optional)

## **Contact Page**

The page shall include:

- Contact form
- Company information
- Social media links
- Location/map section

# **5.2 Authentication System**

The system shall provide:

- User registration
- User login
- Password recovery
- Role-based account access
- Secure authentication system

# **5.3 Course Purchase System**

The system shall:

- Allow users to purchase courses online
- Integrate with the SSLCommerz payment gateway
- Verify successful payments
- Automatically assign purchased courses to users
- Convert registered users into student accounts after successful payment

# **5.4 Course Access System**

The system shall:

- Allow enrolled students to access purchased courses
- Display externally hosted video lessons
- Restrict course access to authorized students only

Note:

- Videos will not be uploaded directly to the server
- Videos will be hosted through external services
- Absolute prevention of downloading cannot be guaranteed

# **5.5 Admin Panel**

The admin panel shall allow administrators to:

## **User Management**

- View users
- Manage student accounts
- Control course access

## **Course Management**

- Create/edit/delete courses
- Add course descriptions
- Add video links
- Manage pricing

## **Project Management**

- Add/edit/delete projects
- Upload project images
- Manage portfolio content

**CMS Management**

- Update homepage content
- Update service sections
- Update contact information
- Manage banners/images

## **Inquiry Management**

- View submitted inquiries
- Manage contact requests

# **6\. Non-Functional Requirements**

# **6.1 Performance**

- The website should load efficiently on desktop and mobile devices
- Pages should be optimized for modern browsers

# **6.2 Security**

- User authentication must be secured
- Role-based access control must be implemented
- Unauthorized users must not access protected course content or admin features

# **6.3 Scalability**

- The architecture should support future expansion
- Additional features and courses should be addable in future versions

# **6.4 Responsiveness**

- The website shall support:
  - Desktop
  - Tablet
  - Mobile devices

**6.5 Availability**

- The website should remain accessible online based on hosting provider uptime

**6.6 Usability**

- The platform should provide a user-friendly interface
- Navigation should be simple and intuitive

# **7\. Video Hosting & Storage Notes**

Course videos will be hosted using third-party services.

Possible options include:

- YouTube (Unlisted)
- Bunny Stream
- Vimeo
- Other CDN/video platforms

The final service selection depends on:

- Number of courses
- Number of videos
- Video duration
- Total storage requirements

Important Notes:

- Videos will not be stored directly on the main application server
- Download prevention can only be partially restricted
- No internet-based video system is 100% non-downloadable

# **What You CAN Do to Reduce Downloading**

You can make it harder.

## **Recommended:**

- Disable right click
- Hide direct video URL
- Use Cloudinary player instead of raw video tag
- Use signed delivery URLs
- Restrict domains
- Stream through embedded player

Still:

determined users can always capture media.

# **8\. Payment Integration**

The platform shall integrate:

- SSLCommerz payment gateway

Features:

- Online payment processing
- Payment verification
- Course assignment after successful payment

# **9\. Hosting & Deployment**

The project deployment will include:

- Frontend hosting (Free \-\> Vercel Free Hosting)
- Backend hosting

Domain and hosting costs are not included in the development fee unless discussed separately.

# **10\. Support & Maintenance**

The Starter Package includes:

- 30 days of support after project delivery

Support includes:

- Bug fixing
- Minor issue resolution

Support does not include:

- Major feature additions
- New module development
- Large design changes

# **11\. Project Timeline**

Estimated development time for Starter Package:

- Approximately 15–25 working days for the first draft

Timeline may vary depending on:

- Client feedback
- Content delivery
- Revision requirements

# **12\. Project Cost**

## **Starter Package Cost**

Not Accessible

# **13\. Payment Terms**

Suggested payment structure:

- 50% advance payment before project start
- Remaining payment after project completion/delivery

# **14\. Assumptions & Limitations**

- Client will provide the necessary content, logos, and course materials
- Course videos will be externally hosted
- Unlimited revisions are not included
- Third-party service pricing may change over time
- Hosting/domain costs are separate unless specified

# **15\. Future Upgrade Possibilities**

The platform architecture can later be extended with:

- Advanced LMS
- Live classes
- Certificates
- Quizzes/exams
- Analytics/reporting
- Mobile application
- Instructor system
- Subscription plans
- Multi-language support
- Notification system
