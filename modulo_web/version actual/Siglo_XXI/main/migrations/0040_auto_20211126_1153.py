# Generated by Django 3.1.3 on 2021-11-26 14:53

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0039_auto_20211126_1130'),
    ]

    operations = [
        migrations.AlterField(
            model_name='detalle_ordenes',
            name='id_orde',
            field=models.IntegerField(default='(null)'),
        ),
    ]